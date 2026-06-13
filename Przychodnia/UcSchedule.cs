using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class UcSchedule : UserControl
    {
        public UcSchedule()
        {
            InitializeComponent();

            LoadDoctors();

            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            button1.Click += button1_Click;
            btnRefresh.Click += button2_Click;

            monthCalendar1.SetDate(DateTime.Today);
            RefreshView();
        }

        private void LoadDoctors()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Wszyscy");

            var doctors = Database.patientList
                .Where(p => !string.IsNullOrEmpty(p.Doctor))
                .Select(p => p.Doctor)
                .Distinct()
                .OrderBy(d => d)
                .ToList();

            foreach (var doctor in doctors)
                comboBox1.Items.Add(doctor);

            comboBox1.SelectedIndex = 0;
        }

        private void RefreshView()
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;
            string selectedDoctor = comboBox1.SelectedItem?.ToString();

            var visits = Database.patientList
                .Where(p => p.DateVisit.Date == selectedDate)
                .ToList();

            if (selectedDoctor != null && selectedDoctor != "Wszyscy")
                visits = visits.Where(p => p.Doctor == selectedDoctor).ToList();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                { HeaderText = "Imię", DataPropertyName = "Name" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                { HeaderText = "Nazwisko", DataPropertyName = "Surname" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                { HeaderText = "PESEL", DataPropertyName = "Pesel" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                { HeaderText = "Godzina", DataPropertyName = "HourVisit" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                { HeaderText = "Lekarz", DataPropertyName = "Doctor" });
            }

            dataGridView1.DataSource = new BindingList<Patient>(visits);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            RefreshView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zaznacz wizytę do usunięcia.");
                return;
            }

            var result = MessageBox.Show("Czy na pewno chcesz usunąć tę wizytę?",
                "Usuń wizytę", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Patient selected = (Patient)dataGridView1.SelectedRows[0].DataBoundItem;
                Database.patientList.Remove(selected);
                Database.Save();
                LoadDoctors();
                RefreshView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDoctors();
            RefreshView();
        }
    }
}
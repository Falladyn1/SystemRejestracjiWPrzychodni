using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Przychodnia
{
    public partial class UcPatientList : UserControl
    {
        public UcPatientList()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            if (dataGridView1.Columns["name"] != null) dataGridView1.Columns["name"].DataPropertyName = "Name";
            if (dataGridView1.Columns["surname"] != null) dataGridView1.Columns["surname"].DataPropertyName = "Surname";
            if (dataGridView1.Columns["pesel"] != null) dataGridView1.Columns["pesel"].DataPropertyName = "Pesel";
            if (dataGridView1.Columns["telNumber"] != null) dataGridView1.Columns["telNumber"].DataPropertyName = "PhoneNumber";

            if (dataGridView1.Columns["nextVisit"] != null)
            {
                dataGridView1.Columns["nextVisit"].DataPropertyName = "DateVisit";
                dataGridView1.Columns["nextVisit"].DefaultCellStyle.Format = "g";
            }
            if (dataGridView1.Columns["ID"] != null) dataGridView1.Columns["ID"].Visible = false;

            dataGridView1.DataSource = Database.patientList;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phrase = textBoxSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(phrase))
            {
                dataGridView1.DataSource = Database.patientList;
            }
            else
            {
                var filteredList = Database.patientList.Where(p =>
                    (p.Pesel != null && p.Pesel.ToLower().Contains(phrase)) ||
                    (p.Surname != null && p.Surname.ToLower().Contains(phrase))
                ).ToList();

                dataGridView1.DataSource = new BindingList<Patient>(filteredList);
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć pacjenta?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Patient selectedPatient = (Patient)dataGridView1.SelectedRows[0].DataBoundItem;

                    Database.patientList.Remove(selectedPatient);
                    Database.Save();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Database.patientList;
                }
            }
            else
            {
                MessageBox.Show("Wybierz pacjenta z listy (zaznacz cały wiersz).");
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Patient selectedPatient = (Patient)dataGridView1.SelectedRows[0].DataBoundItem;

                UcNewPatient editView = new UcNewPatient();
                editView.WczytajDoEdycji(selectedPatient);

                Panel mainPanel = (Panel)this.Parent;
                mainPanel.Controls.Clear();
                editView.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(editView);
            }
            else
            {
                MessageBox.Show("Najpierw zaznacz cały wiersz pacjenta z listy!");
            }
        }
    }
}
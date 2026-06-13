using System;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = System.DateTime.Now.ToString();
            RefreshStats();
        }

        private void RefreshStats()
        {
            DateTime today = DateTime.Today;
            int numOfNextWeekVisits = 0;

            for (int i = 0; i<7; i++)
            {
                DateTime nextWeek = today.AddDays(i);

                var nextWeekVisits = Database.patientList
                .Where(p => p.DateVisit.Date == nextWeek)
                .ToList();

                numOfNextWeekVisits += nextWeekVisits.Count;
            }

            var todayVisits = Database.patientList
                .Where(p => p.DateVisit.Date == today)
                .ToList();


            labelNumOfPatients.Text = todayVisits.Count.ToString();
            labelNumOfNewPatients.Text = numOfNextWeekVisits.ToString();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = new System.ComponentModel.BindingList<Patient>(todayVisits);

            string[] hiddenColumns = { "PhoneNumber", "Email", "Street", "City", "HouseNumber", "Sex", "Date" };
            foreach (string nazwa in hiddenColumns)
            {
                if (dataGridView1.Columns[nazwa] != null)
                    dataGridView1.Columns[nazwa].Visible = false;
            }

            if (dataGridView1.Columns["Name"] != null) dataGridView1.Columns["Name"].HeaderText = "Imię";
            if (dataGridView1.Columns["Surname"] != null) dataGridView1.Columns["Surname"].HeaderText = "Nazwisko";
            if (dataGridView1.Columns["Pesel"] != null) dataGridView1.Columns["Pesel"].HeaderText = "PESEL";
            if (dataGridView1.Columns["DateVisit"] != null)
            {
                dataGridView1.Columns["DateVisit"].HeaderText = "Data Wizyty";
                dataGridView1.Columns["DateVisit"].DefaultCellStyle.Format = "g"; // Pokazuje datę i godzinę
            }
            if (dataGridView1.Columns["HourVisit"] != null) dataGridView1.Columns["HourVisit"].HeaderText = "Godzina";
            if (dataGridView1.Columns["Doctor"] != null) dataGridView1.Columns["Doctor"].HeaderText = "Lekarz";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
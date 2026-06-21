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
            labelTime.Text = System.DateTime.Now.ToString("HH:mm:ss\ndd.MM.yyyy");
            RefreshStats();
        }

        private void RefreshStats()
        {
            DateTime today = DateTime.Today;
            int numOfNextWeekVisits = 0;

            for (int i = 0; i < 7; i++)
            {
                DateTime nextWeek = today.AddDays(i);

                // ZMIANA: Liczymy wizyty w danym dniu
                numOfNextWeekVisits += Database.appointmentList.Count(a => a.DateVisit.Date == nextWeek);
            }

            // Dzisiejsze wizyty
            var todayAppointments = Database.appointmentList
                .Where(a => a.DateVisit.Date == today)
                .OrderBy(a => a.HourVisit)
                .ToList();

            labelNumOfPatients.Text = todayAppointments.Count.ToString();
            labelNumOfNewPatients.Text = numOfNextWeekVisits.ToString();

            // ZMIANA: Tworzymy anonimową listę obiektów, która łączy dane z wizyty i pacjenta na potrzeby DataGridView
            var displayList = todayAppointments.Select(a => {
                var p = Database.patientList.FirstOrDefault(pat => pat.Id == a.PatientId);
                return new
                {
                    Imię = p != null ? p.Name : "Brak",
                    Nazwisko = p != null ? p.Surname : "Brak",
                    PESEL = p != null ? p.Pesel : "Brak",
                    Godzina = a.HourVisit,
                    Lekarz = a.DoctorName
                };
            }).ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = displayList;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
namespace Przychodnia
{
    public partial class SRP : Form
    {
        public SRP()
        {
            InitializeComponent();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            UcDashboard dashboard = new UcDashboard();
            dashboard.Dock = DockStyle.Fill;
            panelMain.Controls.Add(dashboard);

        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UcPatientList patientList = new UcPatientList();
            patientList.Dock = DockStyle.Fill;
            panelMain.Controls.Add(patientList);
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            UcNewPatient addPatient = new UcNewPatient();
            addPatient.Dock = DockStyle.Fill;
            panelMain.Controls.Add(addPatient);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            UcSchedule schedule = new UcSchedule();
            schedule.Dock = DockStyle.Fill;
            panelMain.Controls.Add(schedule);
        }
    }
}

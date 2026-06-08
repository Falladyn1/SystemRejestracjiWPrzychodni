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

            this.VisibleChanged += UcDashboard_VisibleChanged;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = System.DateTime.Now.ToString();
        }

        private void UcDashboard_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                OdswiezStatystyki();
            }
        }

        private void OdswiezStatystyki()
        {
            DateTime dzisiaj = DateTime.Today;

            var dzisiejszeWizyty = Database.patientList
                .Where(p => p.DateVisit.Date == dzisiaj)
                .ToList();

            labelNumOfPatients.Text = dzisiejszeWizyty.Count.ToString();
            labelNumOfNewPatients.Text = Database.patientList.Count.ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dzisiejszeWizyty;

            // Zabezpieczenie na wypadek braku przypisanych kolumn na panelu głównym
            if (dataGridView1.Columns["PhoneNumber"] != null) dataGridView1.Columns["PhoneNumber"].Visible = false;
            if (dataGridView1.Columns["Email"] != null) dataGridView1.Columns["Email"].Visible = false;
            if (dataGridView1.Columns["Street"] != null) dataGridView1.Columns["Street"].Visible = false;
            if (dataGridView1.Columns["City"] != null) dataGridView1.Columns["City"].Visible = false;
            if (dataGridView1.Columns["HouseNumber"] != null) dataGridView1.Columns["HouseNumber"].Visible = false;
            if (dataGridView1.Columns["Sex"] != null) dataGridView1.Columns["Sex"].Visible = false;
            if (dataGridView1.Columns["Date"] != null) dataGridView1.Columns["Date"].Visible = false;
        }
    }
}
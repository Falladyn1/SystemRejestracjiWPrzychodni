using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class UcPatientList : UserControl
    {
        public UcPatientList()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["name"].DataPropertyName = "Name";
            dataGridView1.Columns["surname"].DataPropertyName = "Surname";
            dataGridView1.Columns["pesel"].DataPropertyName = "Pesel";
            dataGridView1.Columns["telNumber"].DataPropertyName = "PhoneNumber";

            dataGridView1.Columns["nextVisit"].DataPropertyName = "DateVisit";
            dataGridView1.Columns["nextVisit"].DefaultCellStyle.Format = "g"; 

            dataGridView1.Columns["ID"].Visible = false;

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
                (p.Surname != null && p.Surname.ToLower().Contains(phrase))).ToList();

                dataGridView1.DataSource = new BindingList<Patient>(filteredList);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class UcNewPatient : UserControl
    {
        public UcNewPatient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBoxName.Text = null;
            textBoxSurname.Text = null;
            maskedTextBoxPesel.Text = null;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            maskedTextBoxPhoneNum.Text = null;
            textBoxEmail.Text = null;
            textBoxStreet.Text = null;
            textBoxHouseNum.Text = null;
            textBoxCity.Text = null;
            dateTimePicker.Value = DateTime.Now;
            comboBoxHours.SelectedIndex = 0;
            comboBoxDoctor.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();

            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxSurname.Text) ||
               maskedTextBoxPesel.Text.Length != 11 ||
                dateTimePicker.Value > DateTime.Now ||
                (!radioButtonFemale.Checked && !radioButtonMale.Checked))
            {
                MessageBox.Show("Uzupelnij wszystkie dane");
                return;
            }

            p.Name=textBoxName.Text;
            p.Surname=textBoxSurname.Text;
            p.Pesel=maskedTextBoxPesel.Text;
            p.Date=dateTimePicker.Value;
            p.Sex = radioButtonMale.Checked;
            p.PhoneNumber=maskedTextBoxPhoneNum.Text;
            p.Email=textBoxEmail.Text;
            p.Street=textBoxStreet.Text;
            p.HouseNumber=textBoxHouseNum.Text;
            p.City=textBoxCity.Text;

            p.DateVisit=monthCalendar1.SelectionRange.Start;
            p.HourVisit=comboBoxHours.Text;
            p.Doctor=comboBoxDoctor.Text;

            Database.patientList.Add(p);
            
        }

        
    }
}

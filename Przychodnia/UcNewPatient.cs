using System;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class UcNewPatient : UserControl
    {
        // Zmienna przechowująca edytowanego pacjenta
        private Patient edytowanyPacjent = null;

        public UcNewPatient()
        {
            InitializeComponent();
        }

        public void WczytajDoEdycji(Patient p)
        {
            edytowanyPacjent = p;

            textBoxName.Text = p.Name;
            textBoxSurname.Text = p.Surname;
            maskedTextBoxPesel.Text = p.Pesel;

            if (p.Date >= dateTimePicker.MinDate && p.Date <= dateTimePicker.MaxDate)
                dateTimePicker.Value = p.Date;

            if (p.Sex == true) radioButtonMale.Checked = true;
            else radioButtonFemale.Checked = true;

            maskedTextBoxPhoneNum.Text = p.PhoneNumber;
            textBoxEmail.Text = p.Email;
            textBoxStreet.Text = p.Street;
            textBoxHouseNum.Text = p.HouseNumber;
            textBoxCity.Text = p.City;

            if (p.DateVisit >= monthCalendar1.MinDate && p.DateVisit <= monthCalendar1.MaxDate)
                monthCalendar1.SetDate(p.DateVisit);

            comboBoxHours.Text = p.HourVisit;
            comboBoxDoctor.Text = p.Doctor;

            label1.Text = "Edycja Pacjenta";
            btnConfirm.Text = "Zapisz Zmiany";
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

            if (comboBoxHours.Items.Count > 0) comboBoxHours.SelectedIndex = 0;
            if (comboBoxDoctor.Items.Count > 0) comboBoxDoctor.SelectedIndex = 0;

            // Reset trybu edycji
            edytowanyPacjent = null;
            label1.Text = "Nowy Pacjent";
            btnConfirm.Text = "Zatwierdź";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) ||
                string.IsNullOrEmpty(textBoxSurname.Text) ||
                maskedTextBoxPesel.Text.Replace("_", "").Length != 11 ||
                dateTimePicker.Value > DateTime.Now ||
                (!radioButtonFemale.Checked && !radioButtonMale.Checked))
            {
                MessageBox.Show("Uzupełnij wszystkie dane poprawnie.");
                return;
            }

            Patient p;
            if (edytowanyPacjent != null)
                p = edytowanyPacjent;
            else
                p = new Patient();

            p.Name = textBoxName.Text;
            p.Surname = textBoxSurname.Text;
            p.Pesel = maskedTextBoxPesel.Text;
            p.Date = dateTimePicker.Value;
            p.Sex = radioButtonMale.Checked;
            p.PhoneNumber = maskedTextBoxPhoneNum.Text;
            p.Email = textBoxEmail.Text;
            p.Street = textBoxStreet.Text;
            p.HouseNumber = textBoxHouseNum.Text;
            p.City = textBoxCity.Text;

            p.DateVisit = monthCalendar1.SelectionRange.Start;
            p.HourVisit = comboBoxHours.Text;
            p.Doctor = comboBoxDoctor.Text;

            if (edytowanyPacjent == null)
            {
                Database.patientList.Add(p);
            }

            Database.Save();

            MessageBox.Show("Zapisano pomyślnie!");
            btnCancel_Click(sender, e);
        }
    }
}
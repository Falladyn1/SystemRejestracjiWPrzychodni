using System;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class UcNewPatient : UserControl
    {
        private Patient currentPatient = null;

        private static readonly string[] availableHours = {
            "08:00", "08:30", "09:00", "09:30", "10:00", "10:30",
            "11:00", "11:30", "12:00", "12:30", "13:00", "13:30",
            "14:00", "14:30", "15:00", "15:30", "16:00", "16:30"
        };

        private static readonly string[] availableDoctors = {
            "dr Jan Kowalski",
            "dr Anna Nowak",
            "dr Piotr Wiśniewski",
            "dr Maria Wójcik"
        };

        public UcNewPatient()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            comboBoxHours.Items.Clear();
            foreach (string hour in availableHours)
                comboBoxHours.Items.Add(hour);

            comboBoxDoctor.Items.Clear();
            foreach (string doctor in availableDoctors)
                comboBoxDoctor.Items.Add(doctor);

            if (comboBoxHours.Items.Count > 0) comboBoxHours.SelectedIndex = 0;
            if (comboBoxDoctor.Items.Count > 0) comboBoxDoctor.SelectedIndex = 0;
        }

        public void LoadForEdit(Patient p)
        {
            currentPatient = p;

            textBoxName.Text = p.Name;
            textBoxSurname.Text = p.Surname;
            maskedTextBoxPesel.Text = p.Pesel;

            if (p.Date >= dateTimePicker.MinDate && p.Date <= dateTimePicker.MaxDate)
                dateTimePicker.Value = p.Date;

            if (p.Sex) radioButtonMale.Checked = true;
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

        // Zostawiam stare nazwę jako wrapper żeby UcPatientList.cs nie wymagało zmian
        public void WczytajDoEdycji(Patient p) => LoadForEdit(p);

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

            currentPatient = null;
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

            Patient p = currentPatient ?? new Patient();

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

            if (currentPatient == null)
                Database.patientList.Add(p);

            Database.Save();

            MessageBox.Show("Zapisano pomyślnie!");
            btnCancel_Click(sender, e);
        }

       
    }
}
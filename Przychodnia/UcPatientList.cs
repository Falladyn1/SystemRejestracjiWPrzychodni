using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

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
            if (dataGridView1.Columns["ID"] != null) dataGridView1.Columns["ID"].Visible = false;

            // Usuwamy powiązanie z niewłaściwymi danymi dla tych dwóch kolumn
            if (dataGridView1.Columns["nextVisit"] != null) dataGridView1.Columns["nextVisit"].DataPropertyName = "";

            if (dataGridView1.Columns["doctorCol"] == null)
            {
                DataGridViewTextBoxColumn doctorColumn = new DataGridViewTextBoxColumn
                {
                    Name = "doctorCol",
                    HeaderText = "LEKARZ"
                };
                dataGridView1.Columns.Add(doctorColumn);
            }

            // Ustawiamy zdarzenie do ręcznego uzupełniania kolumn z wizytami
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            dataGridView1.DataSource = Database.patientList;
        }

        // ZMIANA: Ręcznie wypełniamy komórki wizyty na podstawie AppointmentList
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Patient patient)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "nextVisit" || dataGridView1.Columns[e.ColumnIndex].Name == "doctorCol")
                {
                    // Szukamy najbliższej nadchodzącej wizyty dla tego pacjenta
                    var upcomingVisit = Database.appointmentList
                        .Where(a => a.PatientId == patient.Id && a.DateVisit >= DateTime.Today)
                        .OrderBy(a => a.DateVisit).ThenBy(a => a.HourVisit)
                        .FirstOrDefault();

                    if (upcomingVisit != null)
                    {
                        if (dataGridView1.Columns[e.ColumnIndex].Name == "nextVisit")
                            e.Value = upcomingVisit.FullVisitInfo;
                        else if (dataGridView1.Columns[e.ColumnIndex].Name == "doctorCol")
                            e.Value = upcomingVisit.DoctorName;
                    }
                    else
                    {
                        e.Value = "Brak nadchodzących wizyt";
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phrase = textBoxSearch.Text.Trim().ToLower();
            bool onlyToday = checkBoxToday.Checked;

            dataGridView1.DataSource = Database.FilterPatients(p =>
            {
                bool matchText = string.IsNullOrEmpty(phrase) ||
                                 (p.Pesel != null && p.Pesel.ToLower().Contains(phrase)) ||
                                 (p.Surname != null && p.Surname.ToLower().Contains(phrase));

                // ZMIANA: Sprawdzamy czy pacjent ma na dzisiaj zaplanowaną JAKĄKOLWIEK wizytę
                bool matchDate = !onlyToday || Database.appointmentList.Any(a => a.PatientId == p.Id && a.DateVisit.Date == DateTime.Today);

                return matchText && matchDate;
            });
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć pacjenta? Spowoduje to również usunięcie jego wszystkich wizyt.", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Patient selectedPatient = (Patient)dataGridView1.SelectedRows[0].DataBoundItem;

                    // ZMIANA: Najpierw usuwamy wszystkie wizyty przypisane do tego pacjenta
                    var patientAppointments = Database.appointmentList.Where(a => a.PatientId == selectedPatient.Id).ToList();
                    foreach (var app in patientAppointments)
                    {
                        Database.appointmentList.Remove(app);
                    }

                    // Następnie usuwamy pacjenta
                    Database.patientList.Remove(selectedPatient);
                    Database.Save();

                    btnSearch_Click(sender, e);
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
                editView.LoadForEdit(selectedPatient);

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
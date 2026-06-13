using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class UcSchedule : UserControl
    {
        // Lista wszystkich godzin pracy przychodni
        private static readonly string[] availableHours = {
            "08:00", "08:30", "09:00", "09:30", "10:00", "10:30",
            "11:00", "11:30", "12:00", "12:30", "13:00", "13:30",
            "14:00", "14:30", "15:00", "15:30", "16:00", "16:30"
        };

        // Lista lekarzy pracujących w przychodni
        private static readonly string[] availableDoctors = {
            "dr Jan Kowalski",
            "dr Anna Nowak",
            "dr Piotr Wiśniewski",
            "dr Maria Wójcik"
        };

        public UcSchedule()
        {
            InitializeComponent();

            // Ukrywamy listę rozwijaną lekarza (nie jest już potrzebna, bo wszyscy są w tabeli)
            label2.Visible = false;
            comboBox1.Visible = false;

            // Podłączamy zdarzenia
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;

            monthCalendar1.SetDate(DateTime.Today);
            StyleModernInterface();
            RefreshView();
        }

        private void RefreshView()
        {
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            // Pobieramy wizyty na wybrany dzień
            var visits = Database.patientList
                .Where(p => p.DateVisit.Date == selectedDate)
                .ToList();

            // Czyszczenie tabeli przed nowym renderowaniem
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Ustawienia tabeli (teraz klikamy w konkretną komórkę/kafelek, a nie cały wiersz)
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 1. Dodajemy pierwszą kolumnę z godziną
            dataGridView1.Columns.Add("Hour", "Godzina");
            dataGridView1.Columns["Hour"].Width = 80;
            dataGridView1.Columns["Hour"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Hour"].DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 2. Dodajemy kolumny dla każdego lekarza
            foreach (string doctor in availableDoctors)
            {
                dataGridView1.Columns.Add(doctor, doctor);
                dataGridView1.Columns[doctor].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // 3. Generujemy wiersze dla każdej godziny w dół
            foreach (string hour in availableHours)
            {
                int rowIndex = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowIndex];

                // Stylowanie komórki z godziną (neutralny szary)
                row.Cells["Hour"].Value = hour;
                row.Cells["Hour"].Style.BackColor = Color.FromArgb(245, 245, 245);
                row.Cells["Hour"].Style.ForeColor = Color.FromArgb(53, 73, 94);

                // Sprawdzamy dostępność każdego lekarza o tej godzinie
                foreach (string doctor in availableDoctors)
                {
                    var appointment = visits.FirstOrDefault(p => p.Doctor == doctor && p.HourVisit == hour);
                    var cell = row.Cells[doctor];

                    if (appointment != null)
                    {
                        // Termin ZAJĘTY -> Czerwony kafelek
                        cell.Value = $"{appointment.Name} {appointment.Surname}\nPESEL: {appointment.Pesel}";
                        cell.Style.BackColor = Color.FromArgb(254, 237, 222);
                        cell.Style.ForeColor = Color.FromArgb(211, 47, 47);

                        // Kolor gdy użytkownik kliknie w ten czerwony kafelek
                        cell.Style.SelectionBackColor = Color.FromArgb(250, 200, 180);
                        cell.Style.SelectionForeColor = Color.FromArgb(211, 47, 47);
                    }
                    else
                    {
                        // Termin WOLNY -> Zielony kafelek
                        cell.Value = "Wolne";
                        cell.Style.BackColor = Color.FromArgb(230, 245, 233);
                        cell.Style.ForeColor = Color.FromArgb(46, 125, 50);

                        // Kolor gdy użytkownik kliknie w ten zielony kafelek
                        cell.Style.SelectionBackColor = Color.FromArgb(190, 235, 200);
                        cell.Style.SelectionForeColor = Color.FromArgb(46, 125, 50);
                    }
                }
            }

            // Automatyczne dopasowanie wysokości wierszy dla dłuższego tekstu (żeby zmieściło się Imię i PESEL)
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ApplyGridTheme();
        }

        private void StyleModernInterface()
        {
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            // Przycisk "Usuń wizytę"
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.BackColor = Color.FromArgb(239, 83, 80);
            btnDelete.ForeColor = Color.White;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.Cursor = Cursors.Hand;

            // Przycisk "Odśwież"
            
            
            btnRefresh.Text = "Odśwież";
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.BackColor = Color.FromArgb(38, 166, 154);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefresh.Cursor = Cursors.Hand;
        }

        private void ApplyGridTheme()
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 73, 94);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) => RefreshView();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Najpierw kliknij w czerwoną komórkę z nazwiskiem pacjenta.");
                return;
            }

            var selectedCell = dataGridView1.SelectedCells[0];

            // Zabezpieczenie przed próbą usunięcia kolumny "Godzina"
            if (selectedCell.ColumnIndex == 0)
            {
                MessageBox.Show("Wybrałeś pole z godziną. Kliknij w pole z nazwiskiem pacjenta.");
                return;
            }

            if (selectedCell.Value?.ToString() == "Wolne")
            {
                MessageBox.Show("Ten termin jest już wolny.");
                return;
            }

            string doctorName = dataGridView1.Columns[selectedCell.ColumnIndex].HeaderText;
            string hour = dataGridView1.Rows[selectedCell.RowIndex].Cells["Hour"].Value.ToString();
            DateTime selectedDate = monthCalendar1.SelectionStart.Date;

            var result = MessageBox.Show($"Czy na pewno chcesz usunąć wizytę o {hour} u lekarza {doctorName}?",
                "Usuń wizytę", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Znajdowanie wizyty w bazie i jej usunięcie
                Patient selected = Database.patientList.FirstOrDefault(p =>
                    p.Doctor == doctorName &&
                    p.HourVisit == hour &&
                    p.DateVisit.Date == selectedDate);

                if (selected != null)
                {
                    Database.patientList.Remove(selected);
                    Database.Save();
                    RefreshView();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}
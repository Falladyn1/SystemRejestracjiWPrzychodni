namespace Przychodnia
{
    partial class UcPatientList
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            pesel = new DataGridViewTextBoxColumn();
            telNumber = new DataGridViewTextBoxColumn();
            nextVisit = new DataGridViewTextBoxColumn();
            btnEditPatient = new Button();
            btnScheduleVisit = new Button();
            btnDeletePatient = new Button();
            checkBoxToday = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(19, 25);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Pesel lub nazwisko";
            textBoxSearch.Size = new Size(220, 30);
            textBoxSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(53, 73, 94);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(245, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Szukaj";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 73, 94);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, name, surname, pesel, telNumber, nextVisit });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(19, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(667, 324);
            dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "IMIE";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // surname
            // 
            surname.HeaderText = "Nazwisko";
            surname.MinimumWidth = 6;
            surname.Name = "surname";
            surname.ReadOnly = true;
            // 
            // pesel
            // 
            pesel.HeaderText = "PESEL";
            pesel.MinimumWidth = 6;
            pesel.Name = "pesel";
            pesel.ReadOnly = true;
            // 
            // telNumber
            // 
            telNumber.HeaderText = "TELEFON";
            telNumber.MinimumWidth = 6;
            telNumber.Name = "telNumber";
            telNumber.ReadOnly = true;
            // 
            // nextVisit
            // 
            nextVisit.HeaderText = "NASTĘPNA WIZYTA";
            nextVisit.MinimumWidth = 6;
            nextVisit.Name = "nextVisit";
            nextVisit.ReadOnly = true;
            // 
            // btnEditPatient
            // 
            btnEditPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditPatient.BackColor = Color.FromArgb(52, 152, 219);
            btnEditPatient.FlatAppearance.BorderSize = 0;
            btnEditPatient.FlatStyle = FlatStyle.Flat;
            btnEditPatient.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnEditPatient.ForeColor = Color.White;
            btnEditPatient.Location = new Point(283, 410);
            btnEditPatient.Name = "btnEditPatient";
            btnEditPatient.Size = new Size(120, 30);
            btnEditPatient.TabIndex = 3;
            btnEditPatient.Text = "Edytuj Pacjenta";
            btnEditPatient.UseVisualStyleBackColor = false;
            btnEditPatient.Click += btnEditPatient_Click;
            // 
            // btnScheduleVisit
            // 
            btnScheduleVisit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnScheduleVisit.BackColor = Color.FromArgb(52, 152, 219);
            btnScheduleVisit.FlatAppearance.BorderSize = 0;
            btnScheduleVisit.FlatStyle = FlatStyle.Flat;
            btnScheduleVisit.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnScheduleVisit.ForeColor = Color.White;
            btnScheduleVisit.Location = new Point(566, 410);
            btnScheduleVisit.Name = "btnScheduleVisit";
            btnScheduleVisit.Size = new Size(120, 30);
            btnScheduleVisit.TabIndex = 4;
            btnScheduleVisit.Text = "Umów Wizyte";
            btnScheduleVisit.UseVisualStyleBackColor = false;
            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletePatient.BackColor = Color.FromArgb(239, 83, 80);
            btnDeletePatient.FlatAppearance.BorderSize = 0;
            btnDeletePatient.FlatStyle = FlatStyle.Flat;
            btnDeletePatient.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnDeletePatient.ForeColor = Color.White;
            btnDeletePatient.Location = new Point(424, 410);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new Size(120, 30);
            btnDeletePatient.TabIndex = 5;
            btnDeletePatient.Text = "Usuń Pacjenta";
            btnDeletePatient.UseVisualStyleBackColor = false;
            btnDeletePatient.Click += btnDeletePatient_Click;
            // 
            // checkBoxToday
            // 
            checkBoxToday.AutoSize = true;
            checkBoxToday.Location = new Point(345, 29);
            checkBoxToday.Name = "checkBoxToday";
            checkBoxToday.Size = new Size(128, 24);
            checkBoxToday.TabIndex = 6;
            checkBoxToday.Text = "Tylko dziesjsze";
            checkBoxToday.UseVisualStyleBackColor = true;
            // 
            // UcPatientList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(checkBoxToday);
            Controls.Add(btnDeletePatient);
            Controls.Add(btnScheduleVisit);
            Controls.Add(btnEditPatient);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearch);
            Name = "UcPatientList";
            Size = new Size(702, 453);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnEditPatient;
        private Button btnScheduleVisit;
        private Button btnDeletePatient;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn pesel;
        private DataGridViewTextBoxColumn telNumber;
        private DataGridViewTextBoxColumn nextVisit;
        private CheckBox checkBoxToday;
    }
}

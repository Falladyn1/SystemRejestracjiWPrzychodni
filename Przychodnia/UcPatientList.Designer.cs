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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(19, 25);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Pesel lub nazwisko";
            textBoxSearch.Size = new Size(220, 27);
            textBoxSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(245, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Szukaj";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, name, surname, pesel, telNumber, nextVisit });
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
            nextVisit.HeaderText = "NASTEPNA WIZYTA";
            nextVisit.MinimumWidth = 6;
            nextVisit.Name = "nextVisit";
            nextVisit.ReadOnly = true;
            // 
            // btnEditPatient
            // 
            btnEditPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditPatient.Location = new Point(283, 410);
            btnEditPatient.Name = "btnEditPatient";
            btnEditPatient.Size = new Size(120, 30);
            btnEditPatient.TabIndex = 3;
            btnEditPatient.Text = "Edytuj Pacjenta";
            btnEditPatient.UseVisualStyleBackColor = true;
            btnEditPatient.Click += btnEditPatient_Click;
            // 
            // btnScheduleVisit
            // 
            btnScheduleVisit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnScheduleVisit.Location = new Point(566, 410);
            btnScheduleVisit.Name = "btnScheduleVisit";
            btnScheduleVisit.Size = new Size(120, 30);
            btnScheduleVisit.TabIndex = 4;
            btnScheduleVisit.Text = "Umów Wizyte";
            btnScheduleVisit.UseVisualStyleBackColor = true;
            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeletePatient.Location = new Point(424, 410);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new Size(120, 30);
            btnDeletePatient.TabIndex = 5;
            btnDeletePatient.Text = "Usuń Pacjenta";
            btnDeletePatient.UseVisualStyleBackColor = true;
            btnDeletePatient.Click += btnDeletePatient_Click;
            // 
            // UcPatientList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}

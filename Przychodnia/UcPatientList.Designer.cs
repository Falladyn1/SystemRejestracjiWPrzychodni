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
            textBox1 = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            surname = new DataGridViewTextBoxColumn();
            pesel = new DataGridViewTextBoxColumn();
            telNumber = new DataGridViewTextBoxColumn();
            lastVisit = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 25);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesel lub nazwisko";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(245, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Szukaj";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, name, surname, pesel, telNumber, lastVisit });
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
            // lastVisit
            // 
            lastVisit.HeaderText = "OSTATNIA WIZYTA";
            lastVisit.MinimumWidth = 6;
            lastVisit.Name = "lastVisit";
            lastVisit.ReadOnly = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Location = new Point(283, 410);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edytuj Pacjenta";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Location = new Point(566, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Umów Wizyte";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Location = new Point(424, 410);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Usuń Pacjenta";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // UcPatientList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Name = "UcPatientList";
            Size = new Size(702, 453);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn pesel;
        private DataGridViewTextBoxColumn telNumber;
        private DataGridViewTextBoxColumn lastVisit;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
    }
}

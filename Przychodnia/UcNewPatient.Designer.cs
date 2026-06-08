namespace Przychodnia
{
    partial class UcNewPatient
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
            groupBox3 = new GroupBox();
            maskedTextBoxPhoneNum = new MaskedTextBox();
            textBoxEmail = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            textBoxStreet = new TextBox();
            textBoxCity = new TextBox();
            label11 = new Label();
            textBoxHouseNum = new TextBox();
            label12 = new Label();
            groupBox1 = new GroupBox();
            maskedTextBoxPesel = new MaskedTextBox();
            label2 = new Label();
            radioButtonMale = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            radioButtonFemale = new RadioButton();
            label4 = new Label();
            textBoxName = new TextBox();
            dateTimePicker = new DateTimePicker();
            label3 = new Label();
            textBoxSurname = new TextBox();
            groupBox2 = new GroupBox();
            label13 = new Label();
            comboBoxDoctor = new ComboBox();
            label9 = new Label();
            comboBoxHours = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            btnCancel = new Button();
            btnConfirm = new Button();
            label1 = new Label();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(maskedTextBoxPhoneNum);
            groupBox3.Controls.Add(textBoxEmail);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBoxStreet);
            groupBox3.Controls.Add(textBoxCity);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBoxHouseNum);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(3, 254);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(311, 186);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dane kontaktowe";
            // 
            // maskedTextBoxPhoneNum
            // 
            maskedTextBoxPhoneNum.Location = new Point(24, 46);
            maskedTextBoxPhoneNum.Mask = "000-000-000";
            maskedTextBoxPhoneNum.Name = "maskedTextBoxPhoneNum";
            maskedTextBoxPhoneNum.Size = new Size(125, 27);
            maskedTextBoxPhoneNum.TabIndex = 22;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(157, 46);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(143, 27);
            textBoxEmail.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 23);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 11;
            label8.Text = "E-mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 23);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 0;
            label7.Text = "Nr telefonu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 76);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 15;
            label10.Text = "Ulica";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Location = new Point(24, 99);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(143, 27);
            textBoxStreet.TabIndex = 14;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(24, 152);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(143, 27);
            textBoxCity.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(170, 76);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 16;
            label11.Text = "Nr domu";
            // 
            // textBoxHouseNum
            // 
            textBoxHouseNum.Location = new Point(173, 99);
            textBoxHouseNum.Name = "textBoxHouseNum";
            textBoxHouseNum.Size = new Size(65, 27);
            textBoxHouseNum.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 129);
            label12.Name = "label12";
            label12.Size = new Size(93, 20);
            label12.TabIndex = 18;
            label12.Text = "Miejscowość";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBoxPesel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Location = new Point(3, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane podstawowe";
            // 
            // maskedTextBoxPesel
            // 
            maskedTextBoxPesel.Location = new Point(24, 97);
            maskedTextBoxPesel.Mask = "00000000000";
            maskedTextBoxPesel.Name = "maskedTextBoxPesel";
            maskedTextBoxPesel.Size = new Size(125, 27);
            maskedTextBoxPesel.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 23);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Imię";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(113, 152);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(102, 24);
            radioButtonMale.TabIndex = 9;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Mężczyzna";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 76);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 5;
            label5.Text = "Data urodzenia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 129);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 6;
            label6.Text = "Płeć";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(28, 152);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(82, 24);
            radioButtonFemale.TabIndex = 2;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Kobieta";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 76);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 4;
            label4.Text = "PESEL";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(24, 46);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(113, 27);
            textBoxName.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(155, 97);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(143, 27);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.Value = new DateTime(2026, 6, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 23);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Nazwisko";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(143, 46);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(143, 27);
            textBoxSurname.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(comboBoxDoctor);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBoxHours);
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Location = new Point(320, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 351);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data wizyty";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 291);
            label13.Name = "label13";
            label13.Size = new Size(51, 20);
            label13.TabIndex = 16;
            label13.Text = "Lekarz";
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(12, 314);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(151, 28);
            comboBoxDoctor.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 237);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 14;
            label9.Text = "Godzina";
            // 
            // comboBoxHours
            // 
            comboBoxHours.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHours.FormattingEnabled = true;
            comboBoxHours.Location = new Point(12, 260);
            comboBoxHours.Name = "comboBoxHours";
            comboBoxHours.Size = new Size(151, 28);
            comboBoxHours.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 21);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(320, 411);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.Location = new Point(433, 411);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Zatwierdź";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 0;
            label1.Text = "Nowy Pacjent";
            // 
            // UcNewPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "UcNewPatient";
            Size = new Size(702, 453);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private MaskedTextBox maskedTextBoxPhoneNum;
        private TextBox textBoxEmail;
        private Label label8;
        private Label label7;
        private Label label10;
        private TextBox textBoxStreet;
        private TextBox textBoxCity;
        private Label label11;
        private TextBox textBoxHouseNum;
        private Label label12;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBoxPesel;
        private Label label2;
        private RadioButton radioButtonMale;
        private Label label5;
        private Label label6;
        private RadioButton radioButtonFemale;
        private Label label4;
        private TextBox textBoxName;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private TextBox textBoxSurname;
        private GroupBox groupBox2;
        private Label label13;
        private ComboBox comboBoxDoctor;
        private Label label9;
        private ComboBox comboBoxHours;
        private MonthCalendar monthCalendar1;
        private Button btnCancel;
        private Button btnConfirm;
        private Label label1;
    }
}

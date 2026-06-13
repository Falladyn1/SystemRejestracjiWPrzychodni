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
            groupBox3.Font = new Font("Segoe UI", 10.2F);
            groupBox3.Location = new Point(3, 292);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 214);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dane kontaktowe";
            // 
            // maskedTextBoxPhoneNum
            // 
            maskedTextBoxPhoneNum.BackColor = Color.White;
            maskedTextBoxPhoneNum.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxPhoneNum.Font = new Font("Segoe UI", 10F);
            maskedTextBoxPhoneNum.Location = new Point(27, 53);
            maskedTextBoxPhoneNum.Mask = "000-000-000";
            maskedTextBoxPhoneNum.Name = "maskedTextBoxPhoneNum";
            maskedTextBoxPhoneNum.Size = new Size(140, 30);
            maskedTextBoxPhoneNum.TabIndex = 22;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 10F);
            textBoxEmail.Location = new Point(177, 53);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(160, 30);
            textBoxEmail.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(177, 26);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 11;
            label8.Text = "E-mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 26);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 0;
            label7.Text = "Nr telefonu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 87);
            label10.Name = "label10";
            label10.Size = new Size(47, 23);
            label10.TabIndex = 15;
            label10.Text = "Ulica";
            // 
            // textBoxStreet
            // 
            textBoxStreet.BackColor = Color.White;
            textBoxStreet.BorderStyle = BorderStyle.FixedSingle;
            textBoxStreet.Font = new Font("Segoe UI", 10F);
            textBoxStreet.Location = new Point(27, 114);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new Size(160, 30);
            textBoxStreet.TabIndex = 14;
            // 
            // textBoxCity
            // 
            textBoxCity.BackColor = Color.White;
            textBoxCity.BorderStyle = BorderStyle.FixedSingle;
            textBoxCity.Font = new Font("Segoe UI", 10F);
            textBoxCity.Location = new Point(27, 175);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(160, 30);
            textBoxCity.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(191, 87);
            label11.Name = "label11";
            label11.Size = new Size(79, 23);
            label11.TabIndex = 16;
            label11.Text = "Nr domu";
            // 
            // textBoxHouseNum
            // 
            textBoxHouseNum.BackColor = Color.White;
            textBoxHouseNum.BorderStyle = BorderStyle.FixedSingle;
            textBoxHouseNum.Font = new Font("Segoe UI", 10F);
            textBoxHouseNum.Location = new Point(195, 114);
            textBoxHouseNum.Name = "textBoxHouseNum";
            textBoxHouseNum.Size = new Size(73, 30);
            textBoxHouseNum.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 148);
            label12.Name = "label12";
            label12.Size = new Size(104, 23);
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
            groupBox1.Font = new Font("Segoe UI", 10.2F);
            groupBox1.Location = new Point(3, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 223);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane podstawowe";
            // 
            // maskedTextBoxPesel
            // 
            maskedTextBoxPesel.BackColor = Color.White;
            maskedTextBoxPesel.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBoxPesel.Font = new Font("Segoe UI", 10F);
            maskedTextBoxPesel.Location = new Point(27, 112);
            maskedTextBoxPesel.Mask = "00000000000";
            maskedTextBoxPesel.Name = "maskedTextBoxPesel";
            maskedTextBoxPesel.Size = new Size(140, 30);
            maskedTextBoxPesel.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 26);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 2;
            label2.Text = "Imię";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(127, 175);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(114, 27);
            radioButtonMale.TabIndex = 9;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Mężczyzna";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 87);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 5;
            label5.Text = "Data urodzenia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 148);
            label6.Name = "label6";
            label6.Size = new Size(42, 23);
            label6.TabIndex = 6;
            label6.Text = "Płeć";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(32, 175);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(89, 27);
            radioButtonFemale.TabIndex = 2;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Kobieta";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 87);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 4;
            label4.Text = "PESEL";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.White;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 10F);
            textBoxName.Location = new Point(27, 53);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(127, 30);
            textBoxName.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(174, 112);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(160, 30);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.Value = new DateTime(2026, 6, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 26);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 3;
            label3.Text = "Nazwisko";
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = Color.White;
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Font = new Font("Segoe UI", 10F);
            textBoxSurname.Location = new Point(161, 53);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(160, 30);
            textBoxSurname.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(comboBoxDoctor);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBoxHours);
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Font = new Font("Segoe UI", 10.2F);
            groupBox2.Location = new Point(360, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 404);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data wizyty";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 335);
            label13.Name = "label13";
            label13.Size = new Size(58, 23);
            label13.TabIndex = 16;
            label13.Text = "Lekarz";
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctor.FlatStyle = FlatStyle.Flat;
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(14, 361);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(169, 31);
            comboBoxDoctor.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 273);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 14;
            label9.Text = "Godzina";
            // 
            // comboBoxHours
            // 
            comboBoxHours.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHours.FlatStyle = FlatStyle.Flat;
            comboBoxHours.FormattingEnabled = true;
            comboBoxHours.Location = new Point(14, 299);
            comboBoxHours.Name = "comboBoxHours";
            comboBoxHours.Size = new Size(169, 31);
            comboBoxHours.TabIndex = 13;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(14, 24);
            monthCalendar1.Margin = new Padding(10, 10, 10, 10);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(239, 83, 80);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCancel.Location = new Point(360, 473);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 33);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.BackColor = Color.FromArgb(46, 204, 113);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnConfirm.Location = new Point(487, 473);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(106, 33);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Zatwierdź";
            btnConfirm.UseVisualStyleBackColor = false;
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
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Font = new Font("Segoe UI", 10.2F);
            Name = "UcNewPatient";
            Size = new Size(790, 521);
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

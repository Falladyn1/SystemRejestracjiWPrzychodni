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
            label1 = new Label();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            radioButton2 = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            label4 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            monthCalendar1 = new MonthCalendar();
            groupBox2 = new GroupBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(196, 38);
            label1.TabIndex = 0;
            label1.Text = "Nowy Pacjent";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(20, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane podstawowe";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(24, 97);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 10;
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
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(113, 152);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(102, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mężczyzna";
            radioButton2.UseVisualStyleBackColor = true;
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(28, 152);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kobieta";
            radioButton1.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(24, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 27);
            textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(155, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(143, 27);
            dateTimePicker1.TabIndex = 2;
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
            // textBox2
            // 
            textBox2.Location = new Point(143, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 27);
            textBox2.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(maskedTextBox2);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(20, 256);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(311, 186);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dane kontaktowe";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(24, 46);
            maskedTextBox2.Mask = "000-000-000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(157, 46);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 27);
            textBox5.TabIndex = 12;
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
            // textBox6
            // 
            textBox6.Location = new Point(24, 99);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 27);
            textBox6.TabIndex = 14;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(24, 152);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(143, 27);
            textBox8.TabIndex = 19;
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
            // textBox7
            // 
            textBox7.Location = new Point(173, 99);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(65, 27);
            textBox7.TabIndex = 17;
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(366, 413);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Anuluj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(477, 413);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Zatwierdź";
            button2.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 21);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Location = new Point(337, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 351);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data wizyty";
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 260);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // UcNewPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "UcNewPatient";
            Size = new Size(702, 453);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox textBox8;
        private Label label12;
        private TextBox textBox7;
        private Label label11;
        private Label label10;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label8;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox comboBox1;
    }
}

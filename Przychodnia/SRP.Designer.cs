namespace Przychodnia
{
    partial class SRP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            label3 = new Label();
            btnSettings = new Button();
            btnSchedule = new Button();
            btnNewPatient = new Button();
            btnPatientList = new Button();
            btnDashboard = new Button();
            panelMain = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(33, 43, 54);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnSchedule);
            panelMenu.Controls.Add(btnNewPatient);
            panelMenu.Controls.Add(btnPatientList);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.White;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(130, 453);
            panelMenu.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(0, 379);
            label3.Name = "label3";
            label3.Size = new Size(130, 74);
            label3.TabIndex = 5;
            label3.Text = "System Rezerwacji Pacjentów";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F);
            btnSettings.Location = new Point(5, 274);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(120, 60);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Ustawienia";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 10F);
            btnSchedule.Location = new Point(5, 208);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(120, 60);
            btnSchedule.TabIndex = 3;
            btnSchedule.Text = "Terminarz";
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnNewPatient
            // 
            btnNewPatient.FlatAppearance.BorderSize = 0;
            btnNewPatient.FlatStyle = FlatStyle.Flat;
            btnNewPatient.Font = new Font("Segoe UI", 10F);
            btnNewPatient.Location = new Point(5, 142);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Size = new Size(120, 60);
            btnNewPatient.TabIndex = 1;
            btnNewPatient.Text = "Nowy Pacjent";
            btnNewPatient.UseVisualStyleBackColor = true;
            btnNewPatient.Click += btnNewPatient_Click;
            // 
            // btnPatientList
            // 
            btnPatientList.FlatAppearance.BorderSize = 0;
            btnPatientList.FlatStyle = FlatStyle.Flat;
            btnPatientList.Font = new Font("Segoe UI", 10F);
            btnPatientList.Location = new Point(5, 76);
            btnPatientList.Name = "btnPatientList";
            btnPatientList.Size = new Size(120, 60);
            btnPatientList.TabIndex = 2;
            btnPatientList.Text = "Lista Pacjentów";
            btnPatientList.UseVisualStyleBackColor = true;
            btnPatientList.Click += btnPatientList_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.Location = new Point(5, 10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(120, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Panel Główny";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(label1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(130, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(702, 453);
            panelMain.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(702, 453);
            label1.TabIndex = 6;
            label1.Text = "System Rezerwacji Pacjentów\r\nMateusz Falkowski\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SRP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 453);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Name = "SRP";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnPatientList;
        private Button btnDashboard;
        private Button btnNewPatient;
        private Button btnSchedule;
        private Button btnSettings;
        private Panel panelMain;
        private Label label3;
        private Label label1;
    }
}

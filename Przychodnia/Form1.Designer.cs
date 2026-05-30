namespace Przychodnia
{
    partial class Form1
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
            btnDashboard = new Button();
            btnPatientList = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            label1 = new Label();
            panelNewPatients = new Panel();
            panelPatientNum = new Panel();
            label2 = new Label();
            labelTime = new Label();
            labelNumOfPatients = new Label();
            labelNumOfNewPatients = new Label();
            dataGridView1 = new DataGridView();
            panelMenu.SuspendLayout();
            panelNewPatients.SuspendLayout();
            panelPatientNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Gainsboro;
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnPatientList);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(130, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(5, 10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(120, 30);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Panel Główny";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnPatientList
            // 
            btnPatientList.Location = new Point(5, 46);
            btnPatientList.Name = "btnPatientList";
            btnPatientList.Size = new Size(120, 30);
            btnPatientList.TabIndex = 2;
            btnPatientList.Text = "Lista Pacejntów";
            btnPatientList.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(5, 82);
            button4.Name = "button4";
            button4.Size = new Size(120, 30);
            button4.TabIndex = 1;
            button4.Text = "Nowy Pacjent";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(5, 118);
            button5.Name = "button5";
            button5.Size = new Size(120, 30);
            button5.TabIndex = 3;
            button5.Text = "Terminarz";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(5, 154);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 4;
            button1.Text = "Ustawienia";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Nowi pacjenci:";
            // 
            // panelNewPatients
            // 
            panelNewPatients.BackColor = Color.Gainsboro;
            panelNewPatients.Controls.Add(labelNumOfNewPatients);
            panelNewPatients.Controls.Add(label1);
            panelNewPatients.Location = new Point(660, 10);
            panelNewPatients.Name = "panelNewPatients";
            panelNewPatients.Size = new Size(130, 130);
            panelNewPatients.TabIndex = 3;
            // 
            // panelPatientNum
            // 
            panelPatientNum.BackColor = Color.Gainsboro;
            panelPatientNum.Controls.Add(labelNumOfPatients);
            panelPatientNum.Controls.Add(label2);
            panelPatientNum.Location = new Point(527, 10);
            panelPatientNum.Name = "panelPatientNum";
            panelPatientNum.Size = new Size(130, 130);
            panelPatientNum.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Liczba wizyt dziś:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelTime.Location = new Point(149, 10);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(194, 81);
            labelTime.TabIndex = 5;
            labelTime.Text = "label3";
            // 
            // labelNumOfPatients
            // 
            labelNumOfPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumOfPatients.AutoSize = true;
            labelNumOfPatients.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelNumOfPatients.Location = new Point(50, 50);
            labelNumOfPatients.Name = "labelNumOfPatients";
            labelNumOfPatients.Size = new Size(34, 41);
            labelNumOfPatients.TabIndex = 2;
            labelNumOfPatients.Text = "1";
            // 
            // labelNumOfNewPatients
            // 
            labelNumOfNewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumOfNewPatients.AutoSize = true;
            labelNumOfNewPatients.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelNumOfNewPatients.Location = new Point(50, 50);
            labelNumOfNewPatients.Name = "labelNumOfNewPatients";
            labelNumOfNewPatients.Size = new Size(34, 41);
            labelNumOfNewPatients.TabIndex = 3;
            labelNumOfNewPatients.Text = "1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(149, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(639, 284);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(labelTime);
            Controls.Add(panelPatientNum);
            Controls.Add(panelNewPatients);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelNewPatients.ResumeLayout(false);
            panelNewPatients.PerformLayout();
            panelPatientNum.ResumeLayout(false);
            panelPatientNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button btnPatientList;
        private Button btnDashboard;
        private Button button4;
        private Button button5;
        private Button button1;
        private Label label1;
        private Panel panelNewPatients;
        private Panel panelPatientNum;
        private Label label2;
        private Label labelNumOfPatients;
        private Label labelTime;
        private Label labelNumOfNewPatients;
        private DataGridView dataGridView1;
    }
}

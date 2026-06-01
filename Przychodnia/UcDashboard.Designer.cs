namespace Przychodnia
{
    partial class UcDashboard
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
            components = new System.ComponentModel.Container();
            labelTime = new Label();
            dataGridView1 = new DataGridView();
            panelPatientNum = new Panel();
            labelNumOfPatients = new Label();
            label2 = new Label();
            panelNewPatients = new Panel();
            labelNumOfNewPatients = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelPatientNum.SuspendLayout();
            panelNewPatients.SuspendLayout();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelTime.Location = new Point(16, 10);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(352, 133);
            labelTime.TabIndex = 9;
            labelTime.Text = "time";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(671, 287);
            dataGridView1.TabIndex = 10;
            // 
            // panelPatientNum
            // 
            panelPatientNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelPatientNum.AutoSize = true;
            panelPatientNum.BackColor = Color.GreenYellow;
            panelPatientNum.Controls.Add(labelNumOfPatients);
            panelPatientNum.Controls.Add(label2);
            panelPatientNum.Location = new Point(408, 13);
            panelPatientNum.Name = "panelPatientNum";
            panelPatientNum.Size = new Size(130, 130);
            panelPatientNum.TabIndex = 8;
            // 
            // labelNumOfPatients
            // 
            labelNumOfPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumOfPatients.AutoSize = true;
            labelNumOfPatients.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelNumOfPatients.Location = new Point(46, 50);
            labelNumOfPatients.Name = "labelNumOfPatients";
            labelNumOfPatients.Size = new Size(38, 46);
            labelNumOfPatients.TabIndex = 2;
            labelNumOfPatients.Text = "0";
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
            // panelNewPatients
            // 
            panelNewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNewPatients.AutoSize = true;
            panelNewPatients.BackColor = Color.Gold;
            panelNewPatients.Controls.Add(labelNumOfNewPatients);
            panelNewPatients.Controls.Add(label1);
            panelNewPatients.Location = new Point(557, 13);
            panelNewPatients.Name = "panelNewPatients";
            panelNewPatients.Size = new Size(130, 130);
            panelNewPatients.TabIndex = 7;
            // 
            // labelNumOfNewPatients
            // 
            labelNumOfNewPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumOfNewPatients.AutoSize = true;
            labelNumOfNewPatients.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelNumOfNewPatients.Location = new Point(46, 50);
            labelNumOfNewPatients.Name = "labelNumOfNewPatients";
            labelNumOfNewPatients.Size = new Size(38, 46);
            labelNumOfNewPatients.TabIndex = 3;
            labelNumOfNewPatients.Text = "0";
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
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTime);
            Controls.Add(dataGridView1);
            Controls.Add(panelPatientNum);
            Controls.Add(panelNewPatients);
            Name = "UcDashboard";
            Size = new Size(702, 453);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelPatientNum.ResumeLayout(false);
            panelPatientNum.PerformLayout();
            panelNewPatients.ResumeLayout(false);
            panelNewPatients.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private DataGridView dataGridView1;
        private Panel panelPatientNum;
        private Label labelNumOfPatients;
        private Label label2;
        private Panel panelNewPatients;
        private Label labelNumOfNewPatients;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

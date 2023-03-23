namespace RecordSystemWF.Views
{
    partial class frmHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pChildForm = new Panel();
            panel8 = new Panel();
            dgvRecord = new DataGridView();
            panel6 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            pChildForm.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecord).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // pChildForm
            // 
            pChildForm.Controls.Add(panel8);
            pChildForm.Controls.Add(panel6);
            pChildForm.Dock = DockStyle.Fill;
            pChildForm.Location = new Point(0, 0);
            pChildForm.Name = "pChildForm";
            pChildForm.Size = new Size(1005, 642);
            pChildForm.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvRecord);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 113);
            panel8.Name = "panel8";
            panel8.Size = new Size(1005, 529);
            panel8.TabIndex = 2;
            // 
            // dgvRecord
            // 
            dgvRecord.AllowUserToAddRows = false;
            dgvRecord.AllowUserToDeleteRows = false;
            dgvRecord.AllowUserToOrderColumns = true;
            dgvRecord.BackgroundColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecord.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecord.Dock = DockStyle.Fill;
            dgvRecord.GridColor = Color.FromArgb(25, 25, 25);
            dgvRecord.Location = new Point(0, 0);
            dgvRecord.Name = "dgvRecord";
            dgvRecord.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRecord.RowTemplate.Height = 25;
            dgvRecord.Size = new Size(1005, 529);
            dgvRecord.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1005, 113);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(label4);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.MinimumSize = new Size(1021, 113);
            panel7.Name = "panel7";
            panel7.Size = new Size(1021, 113);
            panel7.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(56, 64);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 0;
            label4.Text = "HISTORY";
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1005, 642);
            Controls.Add(pChildForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistory";
            pChildForm.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecord).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pChildForm;
        private Panel panel8;
        private Panel panel6;
        private Panel panel7;
        private Label label4;
        private DataGridView dgvRecord;
    }
}
namespace RecordSystemWF.Views
{
    partial class frmImport
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
            pChildForm = new Panel();
            panel8 = new Panel();
            btnImport = new Button();
            btnBrowse = new Button();
            tbxPath = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            pChildForm.SuspendLayout();
            panel8.SuspendLayout();
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
            panel8.Controls.Add(btnImport);
            panel8.Controls.Add(btnBrowse);
            panel8.Controls.Add(tbxPath);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 113);
            panel8.Name = "panel8";
            panel8.Size = new Size(1005, 529);
            panel8.TabIndex = 2;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(25, 25, 25);
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 25, 25);
            btnImport.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(706, 60);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(117, 34);
            btnImport.TabIndex = 3;
            btnImport.Text = "IMPORT";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(25, 25, 25);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 25, 25);
            btnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(569, 60);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(117, 34);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // tbxPath
            // 
            tbxPath.BackColor = Color.FromArgb(10, 10, 10);
            tbxPath.BorderStyle = BorderStyle.None;
            tbxPath.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxPath.ForeColor = Color.White;
            tbxPath.Location = new Point(135, 66);
            tbxPath.Name = "tbxPath";
            tbxPath.Size = new Size(416, 22);
            tbxPath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(56, 65);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "PATH";
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
            label4.Size = new Size(99, 30);
            label4.TabIndex = 0;
            label4.Text = "IMPORT";
            // 
            // frmImport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1005, 642);
            Controls.Add(pChildForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmImport";
            pChildForm.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
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
        private TextBox tbxPath;
        private Label label1;
        private Button btnImport;
        private Button btnBrowse;
    }
}
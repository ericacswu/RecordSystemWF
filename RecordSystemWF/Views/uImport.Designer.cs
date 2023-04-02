namespace RecordSystemWF.Views
{
    partial class uImport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            btnImport = new Button();
            btnBrowse = new Button();
            tbxPath = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel8, 0, 1);
            tableLayoutPanel1.Controls.Add(panel7, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8878508F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.11215F));
            tableLayoutPanel1.Size = new Size(1005, 642);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnImport);
            panel8.Controls.Add(btnBrowse);
            panel8.Controls.Add(tbxPath);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 105);
            panel8.Name = "panel8";
            panel8.Size = new Size(999, 534);
            panel8.TabIndex = 3;
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
            // panel7
            // 
            panel7.Controls.Add(label4);
            panel7.Location = new Point(3, 3);
            panel7.MinimumSize = new Size(1005, 113);
            panel7.Name = "panel7";
            panel7.Size = new Size(1005, 113);
            panel7.TabIndex = 2;
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
            // uImport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            Controls.Add(tableLayoutPanel1);
            Name = "uImport";
            Size = new Size(1005, 642);
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel7;
        private Label label4;
        private Panel panel8;
        private Button btnImport;
        private Button btnBrowse;
        private TextBox tbxPath;
        private Label label1;
    }
}

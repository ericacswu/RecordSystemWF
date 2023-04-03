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
            panel7 = new Panel();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            btnPreview = new Button();
            label1 = new Label();
            tbxPath = new TextBox();
            btnImport = new Button();
            btnBrowse = new Button();
            dgvPreview = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(20, 20, 20);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel7, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8878508F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.11215F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1021, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(20, 20, 20);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(1015, 102);
            panel7.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(56, 66);
            label4.Name = "label4";
            label4.Size = new Size(99, 30);
            label4.TabIndex = 0;
            label4.Text = "IMPORT";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(20, 20, 20);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvPreview, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 111);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3558483F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87.64415F));
            tableLayoutPanel2.Size = new Size(1015, 567);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(btnPreview);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbxPath);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnBrowse);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 64);
            panel1.TabIndex = 6;
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.FromArgb(25, 25, 25);
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 25, 25);
            btnPreview.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(667, 20);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(131, 31);
            btnPreview.TabIndex = 4;
            btnPreview.Text = "PREVIEW";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(53, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "PATH";
            // 
            // tbxPath
            // 
            tbxPath.BackColor = Color.FromArgb(10, 10, 10);
            tbxPath.BorderStyle = BorderStyle.None;
            tbxPath.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxPath.ForeColor = Color.White;
            tbxPath.Location = new Point(130, 24);
            tbxPath.Name = "tbxPath";
            tbxPath.Size = new Size(375, 22);
            tbxPath.TabIndex = 1;
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
            btnImport.Location = new Point(848, 21);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(118, 31);
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
            btnBrowse.Location = new Point(530, 21);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(131, 31);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "BROWSE";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // dgvPreview
            // 
            dgvPreview.AllowUserToAddRows = false;
            dgvPreview.AllowUserToDeleteRows = false;
            dgvPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPreview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvPreview.BackgroundColor = Color.FromArgb(15, 15, 15);
            dgvPreview.BorderStyle = BorderStyle.None;
            dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreview.Location = new Point(3, 73);
            dgvPreview.Name = "dgvPreview";
            dgvPreview.ReadOnly = true;
            dgvPreview.RowTemplate.Height = 25;
            dgvPreview.Size = new Size(1009, 491);
            dgvPreview.TabIndex = 4;
            // 
            // uImport
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(20, 20, 20);
            Controls.Add(tableLayoutPanel1);
            Name = "uImport";
            Size = new Size(1021, 681);
            Load += uImport_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel7;
        private Label label4;
        private Button btnImport;
        private Button btnBrowse;
        private TextBox tbxPath;
        private Label label1;
        private DataGridView dgvPreview;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button btnPreview;
    }
}

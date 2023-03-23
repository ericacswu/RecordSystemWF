using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using RecordSystemWF.Models.Context;
using RecordSystemWF.Views;
using System.Configuration;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace RecordSystemWF
{
    public partial class frmMain : Form
    {
        private readonly StringingRecordContext context;
        bool showRecordsPanel = false;
        bool showSettingsPanel = false;

        public frmMain()
        {
            InitializeComponent();
            togglePanels();
        }

        #region TogglePanels
        private void togglePanels()
        {
            if (showRecordsPanel)
                pRecords.Height = 80;
            else
                pRecords.Height = 0;

            if (showSettingsPanel)
                pSettings.Height = 80;
            else
                pSettings.Height = 0;
        }


        private void btnRecords_Click(object sender, EventArgs e)
        {
            showRecordsPanel = !showRecordsPanel;
            togglePanels();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSettingsPanel = !showSettingsPanel;
            togglePanels();
        }
        #endregion

        public void setChildForm(Form form)
        {
            if(form != this)
            {
                pChildForm.Visible = false;
            }

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            // Set the Parent Form of the Child window.
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;

            spcMain.Panel2.Controls.Add(form);

            form.Show();
        }

        #region Button Functions
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            pChildForm.Dock = DockStyle.Fill;
            pChildForm.Visible = true;
            pChildForm.Show();
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory form = new frmHistory();
            setChildForm(form);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnString_Click(object sender, EventArgs e)
        {

        }

        private void btnOthers_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (var data = new StringingRecordContext())
            {
                var test = ConfigurationManager.ConnectionStrings["ConnectionString"];
                string connectionString = test.ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                    //MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }
    }
}
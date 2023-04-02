using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using RecordSystemWF.Models.Context;
using RecordSystemWF.Views;
using System.Configuration;
using System.Diagnostics;
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
            this.IsMdiContainer = true;
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

        public void setUserControl(UserControl control)
        {
            spcMain.Panel2.Controls.Add(control);
            control.Show();
            control.BringToFront();
        }

        #region Button Functions
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            foreach (Control c in spcMain.Panel2.Controls)
            {
                if (c.GetType().BaseType == typeof(UserControl))// && c != controlToLeaveOpen)
                {
                    spcMain.Panel2.Controls.Remove(c);
                    c.Dispose();
                }
            }
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            uHistory uHistory = new uHistory();
            setUserControl(uHistory);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            uImport uImport = new uImport();
            setUserControl(uImport);
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
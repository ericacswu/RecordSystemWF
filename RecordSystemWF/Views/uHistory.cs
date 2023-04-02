using MySqlConnector;
using RecordSystemWF.Helper;
using RecordSystemWF.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordSystemWF.Views
{
    public partial class uHistory : UserControl
    {
        CommFunction cf = new CommFunction();
        StringingRecordContext context = new StringingRecordContext();

        public uHistory()
        {
            InitializeComponent();
            init();
        }

        private async Task init()
        {
            await LoadRecord();
        }

        private async Task LoadRecord()
        {
            using (var data = new StringingRecordContext())
            {
                var test = ConfigurationManager.ConnectionStrings["ConnectionString"];
                string connectionString = test.ConnectionString;
                MySqlConnection connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                    string sSQL = "SELECT * FROM string_record";
                    DataTable dt = new DataTable();
                    dt = await context.DataTable(sSQL);
                    dgvRecord.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }

        private void uHistory_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("uHistory loaded");
            cf.setDataGridView(dgvRecord);
        }
    }
}

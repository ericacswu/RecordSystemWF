using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using RecordSystemWF.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordSystemWF.Views
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            LoadRecord();
        }

        private void LoadRecord()
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
                    using (var command = new MySqlCommand(sSQL, connection))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    dgvRecord.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
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
using System.Security.Cryptography.X509Certificates;
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

                    string totalIncome = cf.getTotalIncome();
                    lblTotalIncome.Text = "TOTAL INCOME: $" + totalIncome;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }

        private void uHistory_Load(object sender, EventArgs e)
        {
            cf.setDataGridView(dgvRecord);
        }

        private async Task Search()
        {
            try
            {
                List<MySqlParameter> listParameters = new List<MySqlParameter>();
                string sCondition = "";
                string sSQL = @"
                                SELECT *
                                FROM string_record
                                WHERE 1 = 1
                                {0}
                                ";
                if (!string.IsNullOrEmpty(tbxName.Text))
                {
                    sCondition = " AND Name like @Name";
                    listParameters.Add(new MySqlParameter("@Name", "%" + tbxName.Text + "%"));
                }
                sSQL = string.Format(sSQL, sCondition);
                using (var data = new StringingRecordContext())
                {
                    var listResult = await data.DataTable(sSQL, listParameters.ToArray());
                    if (listResult.Rows.Count > 0)
                    {
                        dgvRecord.DataSource = null;
                        dgvRecord.DataSource = listResult;
                    }
                }
            }
            catch (Exception ex)
            {
                cf.showErrorMessage("ERROR", ex.Message);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}

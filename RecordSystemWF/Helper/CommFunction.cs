using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using RecordSystemWF.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordSystemWF.Helper
{
    public class CommFunction
    {
        StringingRecordContext context = new StringingRecordContext();

        Color backgroundColor = Color.FromArgb(20, 20, 20);

        public void setDataGridView(DataGridView dgv)
        {
            dgv.DefaultCellStyle.BackColor = backgroundColor;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = backgroundColor;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = backgroundColor;
            dgv.EnableHeadersVisualStyles = false; // 設定 false columnheader 效果才顯現
            dgv.BackgroundColor = backgroundColor;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            dgv.ForeColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dgv.CellMouseMove += dataGridView_CellMouseMove;
            //dgv.CellMouseLeave += dataGridView_CellMouseLeave;
            dgv.ScrollBars = ScrollBars.Both;
        }

        public void showErrorMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void showSuccessMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string? stringToDateTime(string? dateString)
        {
            if (string.IsNullOrEmpty(dateString))
                return null;

            DateTime dateTime;
            if (DateTime.TryParseExact(dateString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
            {
                string formattedDateTime = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                return formattedDateTime;
            }
            else
            {
                return null; // return null or throw an exception to indicate that the parse failed
            }
        }

        public int getStringType(string shortName)
        {
            int typeID = 0;
            List<MySqlParameter> listParameters = new List<MySqlParameter>();
            string sCondition = "";
            string sSQL = @"
                            SELECT TypeID
                            FROM string_type
                            WHERE 1 = 1
                            {0}
                            ";
            if(!string.IsNullOrEmpty(shortName))
            {
                sCondition = " AND ShortName like @ShortName";
                listParameters.Add(new MySqlParameter("@ShortName", "%" + shortName + "%"));
            }
            sSQL = string.Format(sSQL, sCondition);
            var listResult = context.Database.SqlQueryRaw<int>(sSQL, listParameters.ToArray()).ToList();
            if (listResult.Count > 0)
            {
                typeID = listResult[0];
            }
            return typeID;
        }

        public string getTotalIncome()
        {
            string income = "";
            List<MySqlParameter> listParameters = new List<MySqlParameter>();
            string sSQL = @"
                            SELECT FORMAT(SUM(TotalPrice), 2)
                            FROM string_record;
                            ";
            var listResult = context.Database.SqlQueryRaw<string>(sSQL).ToList();
            if (listResult.Count > 0)
            {
                income = listResult[0];
            }
            return income;
        }
    }
}

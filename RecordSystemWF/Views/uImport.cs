using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using RecordSystemWF.Helper;
using RecordSystemWF.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordSystemWF.Views
{
    public partial class uImport : UserControl
    {
        CommFunction cf = new CommFunction();
        StringingRecordContext context = new StringingRecordContext();
        DataTable importSource = new DataTable();

        public uImport()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                tbxPath.Text = filePath;
                GetExcelData(filePath);
            }
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            dgvPreview.DataSource = null;
            dgvPreview.DataSource = importSource;
        }

        private void GetExcelData(string filePath)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    XSSFWorkbook workbook = new XSSFWorkbook(stream);
                    ISheet sheet = workbook.GetSheetAt(0);
                    IRow headerRow = sheet.GetRow(0);
                    int columnCount = headerRow.LastCellNum;
                    for (int i = headerRow.FirstCellNum; i < columnCount; i++)
                        dt.Columns.Add(new DataColumn(headerRow.GetCell(i).ToString()));
                    //Read Excel File
                    for (int i = (sheet.FirstRowNum + 2); i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue;
                        if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;

                        DataRow dataRow = dt.NewRow();

                        //依先前取得的欄位數逐一設定欄位內容
                        for (int j = row.FirstCellNum; j < columnCount; j++)
                        {
                            ICell cell = row.GetCell(j);
                            if (cell != null)
                            {
                                switch (cell.CellType)
                                {
                                    case CellType.Numeric:
                                        if (DateUtil.IsCellDateFormatted(cell))
                                        {
                                            dataRow[j] = cell.DateCellValue;
                                        }
                                        else
                                        {
                                            dataRow[j] = cell.NumericCellValue;
                                        }
                                        break;
                                    case CellType.Formula:
                                        switch (cell.CachedFormulaResultType)
                                        {
                                            case CellType.Numeric:
                                                dataRow[j] = cell.NumericCellValue;
                                                break;
                                            default:
                                                dataRow[j] = cell.StringCellValue;
                                                break;
                                        }
                                        break;
                                    default: // String
                                        dataRow[j] = cell.StringCellValue;
                                        break;
                                }
                            }
                        }
                        dt.Rows.Add(dataRow);
                    }
                }
                importSource = dt;
            }
            catch (Exception ex)
            {
                cf.showErrorMessage("ERROR", ex.Message);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxPath.Text) && importSource != null)
            {
                Import(tbxPath.Text, importSource);
            }
            else
            {
                cf.showErrorMessage("ERROR", "Path cannot be empty.");
            }
        }

        private void Import(string filePath, DataTable dt)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int status = 0;
                        int payStatus = 0;
                        string? paid = row["已收費用"].ToString();

                        if (string.IsNullOrEmpty(row["完成日期"].ToString()))
                            status = 0;
                        else if (!string.IsNullOrEmpty(row["完成日期"].ToString()))
                            status = 1;

                        if (!string.IsNullOrEmpty(paid) && paid != "0" && !string.IsNullOrEmpty(row["完成日期"].ToString()))
                        {
                            status = 2;
                            payStatus = 1;
                        }

                        if(!string.IsNullOrEmpty(paid) && paid != "0")
                            payStatus = 1;
                        else
                            payStatus = 0;

                        string? receivedDate = cf.stringToDateTime(row["收拍日期"].ToString());
                        string? completedDate = cf.stringToDateTime(row["完成日期"].ToString());

                        string sSQL = @"
                                        CALL SYS_IMPORT_RECORD(
                                            @Status, @Name, @RacketName, 
                                            @StringType, @LBS, @TotalPrice, 
                                            @PayStatus, @ReceivedDate, @FinishedDate, 
                                            @Remark);
                                        ";

                        List<MySqlParameter> listParameters = new List<MySqlParameter>();
                        listParameters.Add(new MySqlParameter("@Status", status));
                        listParameters.Add(new MySqlParameter("@Name", row["姓名"].ToString()));
                        listParameters.Add(new MySqlParameter("@RacketName", row["球拍"].ToString()));
                        listParameters.Add(new MySqlParameter("@StringType", row["線種"].ToString()));
                        listParameters.Add(new MySqlParameter("@LBS", row["磅數"].ToString()));
                        listParameters.Add(new MySqlParameter("@TotalPrice", row["費用"].ToString()));
                        listParameters.Add(new MySqlParameter("@PayStatus", payStatus));
                        listParameters.Add(new MySqlParameter("@ReceivedDate", receivedDate));
                        listParameters.Add(new MySqlParameter("@FinishedDate", completedDate));
                        listParameters.Add(new MySqlParameter("@Remark", row["備註"].ToString()));

                        context.Database.ExecuteSqlRaw(sSQL, listParameters.ToArray());
                    }
                    transaction.Commit();
                    return;
                }
                catch (Exception ex)
                {
                    context.Database.RollbackTransaction();
                    cf.showErrorMessage("IMPORT FAILED", ex.Message);
                    return;
                }
            }
        }

        private void uImport_Load(object sender, EventArgs e)
        {
            cf.setDataGridView(dgvPreview);
        }

    }
}

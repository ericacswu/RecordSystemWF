using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using RecordSystemWF.Helper;
using RecordSystemWF.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordSystemWF.Views
{
    public partial class frmImport : Form
    {
        CommFunction cf = new CommFunction();
        StringingRecordContext context = new StringingRecordContext();

        public frmImport()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                tbxPath.Text = filePath;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private async Task Import()
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    //            foreach (var data in listLoanAccountBranch)
                    //            {
                    //                if (!string.IsNullOrEmpty(data.LoanIObank))
                    //                {
                    //                    List<SqlParameter> listParameters = new List<SqlParameter>();
                    //                    listParameters.Add(new SqlParameter("@LoanIObank", data.LoanIObank));
                    //                    listParameters.Add(new SqlParameter("@AccountBranch", data.AccountBranch));
                    //                    listParameters.Add(new SqlParameter("@PartnerID", data.partnerID));
                    //                    listParameters.Add(new SqlParameter("@OBankFlag", "已撥款"));
                    //                    listParameters.Add(new SqlParameter("@PartnerFlag", "策盟撥款"));

                    //                    await context.Database.ExecuteSqlRawAsync(
                    //                    @"
                    //	BEGIN
                    //		DECLARE @LoanIPartner VARCHAR(50)

                    //		SELECT @LoanIPartner = o.LoanIPartner
                    //		FROM G_ORDER o
                    //		LEFT JOIN G_OBANK ok ON ok.LoanIPartner = o.LoanIPartner and ok.PartnerID = o.PartnerID
                    //		WHERE ok.LoanIObank = @LoanIObank
                    //		AND ok.PartnerID = @PartnerID

                    //		UPDATE G_ORDER
                    //		SET AccountBranch = @AccountBranch
                    //		WHERE PartnerID = @PartnerID
                    //		AND LoanIPartner = @LoanIPartner

                    //		EXEC UpdateOrderFlag @LoanIObank, @LoanIPartner, @OBankFlag, @PartnerFlag
                    //	END
                    //", listParameters);
                    //                }
                    //            }

                    await context.SaveChangesAsync();
                    transaction.Commit();
                    return;
                }
                catch (Exception ex)
                {
                    await context.Database.RollbackTransactionAsync(); ;
                    return;
                }
            }
        }
    }
}

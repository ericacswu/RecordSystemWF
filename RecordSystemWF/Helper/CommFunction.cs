using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordSystemWF.Helper
{
    public class CommFunction
    {
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
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
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

    }
}

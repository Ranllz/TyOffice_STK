using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace STK_Client.M01_基础设置
{
    public partial class BAS_仓库设置 : Form
    {
        public BAS_仓库设置()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_仓库设置"));
            AppServer.SetGridViewStyle(this.dbGridView);
            //
            this.DataBinding_dbGridView(0);
        }

        public void DataBinding_dbGridView(int ARowIndex)
        {
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "SLCCK";
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_仓库_List(model).Tables[0];
            });
            //
            this.lbl查询记录.Text = String.Format("共有 {0} 条记录", this.dbGridView.RowCount.ToString());
            //
            this.dbGridView.GoToRowByIndex(ARowIndex);
        }

        private void dbGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnMod.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var fm = new M02_仓库设置_Editor())
            {
                fm.Editor_Add();
                if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.DataBinding_dbGridView(0);
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //
            using (var fm = new M02_仓库设置_Editor())
            {
                fm.Editor_Mod(this.dbGridView.SelectedRows[0]);
                if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbGridView.SelectedRows[0].Index);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.Rows.Count == 0) return;
            if (this.dbGridView.SelectedRows.Count == 0) return;
            if (!AppServer.DialogMsg("确定要删除该仓库？")) return;
            //
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "Del";
            AppServer.UsingWcf(() =>
            {
                foreach (DataGridViewRow Row in this.dbGridView.SelectedRows)
                {
                    model.仓库编码 = Row.Cells["仓库编码"].Value.ToString();
                    AppServer.wcfClient.BAS_仓库_Edit(ref model);
                }
            });
            //
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_Error(model.ErrorMsg);
            }
            else
            {
                this.DataBinding_dbGridView(0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

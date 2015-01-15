using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using TY.Grids;

namespace STK_Client.M01_基础设置
{
    public partial class BAS_供应商设置 : Form
    {
        public BAS_供应商设置()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_供应商设置"));
            AppServer.SetGridViewStyle(this.dbGridView);
            //
            this.DataBinding_dbGridView(0);
        }

        private void DataBinding_dbGridView(int ARowIndex)
        {
            var model = new Ref_WS_STK.DataType_供应商();
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_供应商_List(model).Tables[0];
            });
            //
            this.lblRowCnt.Text = String.Format("共有 {0} 条记录", this.dbGridView.RowCount.ToString());
            //
            this.dbGridView.GoToRowByIndex(ARowIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new BAS_供应商设置_Editor())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(0);
                    if (this.dbGridView.Rows.Count > 0) TY.Helper.GridHelper.GoToRowByIndex(this.dbGridView, 0);
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //         
            string Code = this.dbGridView.SelectedRows[0].Cells["供应商编码"].Value.ToString();
            using (BAS_供应商设置_Editor form = new BAS_供应商设置_Editor())
            {
                form.Editor_Mod(this.dbGridView.SelectedRows[0]);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index);
                    TY.Helper.GridHelper.GotoGridRowByCode(this.dbGridView, "供应商编码", Code);
                    this.dbGridView.Focus();
                }
            }
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.Rows.Count == 0) return;
            if (this.dbGridView.SelectedRows.Count == 0) return;
            if (!AppServer.DialogMsg("确定要删除该供应商？")) return;
            //
            var model = new Ref_WS_STK.DataType_供应商();
            model.ExAction = "Del";
            AppServer.UsingWcf(() =>
            {
                foreach (DataGridViewRow Row in this.dbGridView.SelectedRows)
                {
                    model.供应商编码 = Row.Cells["供应商编码"].Value.ToString();
                    AppServer.wcfClient.BAS_供应商_Edit(ref model);
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

        private void dbGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnMod.PerformClick();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.dbGridView.Preview(this.lblTitle.Text, "A4", true, AppServer.PrintUnitName, "@页码");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

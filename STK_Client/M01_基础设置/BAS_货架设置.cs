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
    public partial class BAS_货架设置 : Form
    {
        public BAS_货架设置()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_货架设置"));
            AppServer.SetGridViewStyle(this.dbGridView);
            //
            this.DataBinding_cbx仓库编码();
        }

        private void DataBinding_cbx仓库编码()
        {
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "AllCK";
            model.包含所有项 = 1;
            AppServer.UsingWcf(() =>
            {
                this.cbx仓库编码.ValueMember = "仓库编码";
                this.cbx仓库编码.DisplayMember = "仓库名称";
                this.cbx仓库编码.DataSource = AppServer.wcfClient.BAS_仓库_List(model).Tables[0];
            });
            //
            this.cbx仓库编码.SelectedIndex = 0;
        }

        public void DataBinding_dbGridView(int ARowIndex)
        {
            var model = new Ref_WS_STK.DataType_仓库();
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            model.仓库名称 = this.txt货架名称.Text;
            model.ExAction = "SLCHJ";
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_货架_List(model).Tables[0];
            });
            //
            this.lbl查询记录.Text = String.Format("共有 {0} 条记录", this.dbGridView.RowCount.ToString());
            //
            this.dbGridView.GoToRowByIndex(ARowIndex);
        }

        private void cbx仓库编码_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(0);
        }

        private void txt货架名称_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn查询.PerformClick();
            }
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(0);
        }

        private void AddNewDataEvent(string value)
        {
            this.cbx仓库编码.SelectedValue = value;
            this.DataBinding_dbGridView(0);
            if (this.dbGridView.Rows.Count > 0)
            {
                this.dbGridView.GoToRowByIndex(this.dbGridView.Rows.Count - 1);
                dbGridView.FirstDisplayedScrollingRowIndex = dbGridView.Rows[this.dbGridView.Rows.Count - 1].Index;
            }
        }

        private void dbGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnMod.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var fm = new BAS_货架设置_Editor())
            {
                fm.OnAddNewDataEvent = AddNewDataEvent;
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
            using (var fm = new BAS_货架设置_Editor())
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
            if (!AppServer.DialogMsg("确定要删除该货架？")) return;
            //
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "Del";           
            AppServer.UsingWcf(() =>
            {
                foreach (DataGridViewRow Row in this.dbGridView.SelectedRows)
                {
                    model.仓库编码 = Row.Cells["仓库编码"].Value.ToString();
                    AppServer.wcfClient.BAS_货架_Edit(ref model);
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

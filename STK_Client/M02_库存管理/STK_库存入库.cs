using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace STK_Client.M02_库存管理
{
    public partial class STK_库存入库 : Form
    {
        public STK_库存入库()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("STK_库存入库"));
            //
            this.dtp开始时间.Value = DateTime.Now.AddDays(-1);
            //
            this.DataBinding_cbx仓库编码();
        }

        private void DataBinding_cbx仓库编码()
        {
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "AllCK";
            AppServer.UsingWcf(() =>
            {
                this.cbx仓库编码.ValueMember = "仓库编码";
                this.cbx仓库编码.DisplayMember = "仓库名称";
                this.cbx仓库编码.DataSource = AppServer.wcfClient.BAS_仓库_List(model).Tables[0];
            });
        }

        private void cbx仓库编码_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(0);
        }

        private void txt单据编码_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DataBinding_dbGridView(0);
            }
        }

        private void chk所有未审核_CheckedChanged(object sender, EventArgs e)
        {
            this.dtp开始时间.Enabled = !this.chk所有未审核.Checked;
            this.dtp结束时间.Enabled = !this.chk所有未审核.Checked;
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(0);
        }

        private void DataBinding_dbGridView(int ARowIndex)
        {
            var model = new Ref_WS_STK.DataType_库存管理();
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.STK_库存入库_List(model).Tables[0];
            });
            //
            this.dbGridView.GoToRowByIndex(ARowIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var Fm = new STK_库存入库_Editor())
            {
                Fm.Editor_Add();
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.DataBinding_dbGridView(0);
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            if (!String.IsNullOrWhiteSpace(this.dbGridView.SelectedRows[0].Cells["审核时间"].Value.ToString()))
            {
                AppServer.ShowMsg_Warn("该入库单已被审核，不能再修改了！");
                return;
            }
            //
            using (var Fm = new STK_库存入库_Editor())
            {
                Fm.Editor_Mod(this.dbGridView.SelectedRows[0].Cells["单据编码"].Value.ToString());
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.Rows.Count == 0) return;
            if (!AppServer.DialogMsg(String.Format("确定要删除“{0}”入库单？", 
                                        this.dbGridView.SelectedRows[0].Cells["单据编码"].Value))) return;
            //
            var model = new Ref_WS_STK.DataType_库存管理();
            model.ExAction = "Del";
            model.单据编码 = this.dbGridView.SelectedRows[0].Cells["单据编码"].Value.ToString();
            model.LoginUserCode = AppServer.LoginUserCode;
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.STK_库存入库_Edit(ref model);
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

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //
            using (var Fm = new STK_库存入库_Editor())
            {
                Fm.Editor_See(this.dbGridView.SelectedRows[0].Cells["单据编码"].Value.ToString());
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { 
                }
            }
        }

        private void dbGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btn查看.PerformClick();
        }

        private void btn打印_Click(object sender, EventArgs e)
        {
            AppServer.ShowMsg("该功能正在完善...");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

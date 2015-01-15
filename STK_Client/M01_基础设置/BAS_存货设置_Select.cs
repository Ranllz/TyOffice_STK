using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using TY.Controls;

namespace STK_Client.M01_基础设置
{
    public partial class BAS_存货设置_Select : Form
    {
        public int Index = 0;
        public string CHInfo = "";

        public BAS_存货设置_Select()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_存货设置_Select"));
            AppServer.SetGridViewStyle(this.dbGridView);
        }

        private string _lbcode = "";
        public void Select_Mod(string LBCode)
        {
            _lbcode = LBCode;
            this.DataBinding_dbGridView();
        }

        private void txt存货名称_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn查询.PerformClick();
            }
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView();
        }

        public void DataBinding_dbGridView()
        { 
            var model = new Ref_WS_STK.DataType_存货();
            model.类别编码 = _lbcode;
            model.包含下级 = false;
            model.存货名称 = this.txt存货名称.Text.Trim();
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_存货_List(model).Tables[0];
            });
        }

        private void dbGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnSelect.PerformClick();
        }

        private void BAS_存货设置_Select_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnSelect.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.btnClose.PerformClick();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0)
            {
                AppServer.ShowMsg("请选择存货");
                return;
            }
            //
            this.Index = this.dbGridView.CurrentRow.Cells["类别序号"].Value.ToIntegerDef();
            this.CHInfo = String.Format("{0} {1}({2})", this.dbGridView.CurrentRow.Cells["存货名称"].Value
                , this.dbGridView.CurrentRow.Cells["规格型号"].Value
                , this.dbGridView.CurrentRow.Cells["类别序号"].Value);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}

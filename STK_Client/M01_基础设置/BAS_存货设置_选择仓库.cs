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
    public partial class BAS_存货设置_选择仓库 : Form
    {
        public string CKCodes = "";
        public string CKNames = "";

        public BAS_存货设置_选择仓库()
        {
            InitializeComponent();
            //
            this.Text = "选择默认仓库";
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_存货设置_选择仓库"));
            AppServer.SetGridViewStyle(this.dbGridView);
            this.dbGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
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
            this.dbGridView.GoToRowByIndex(ARowIndex);
        }

        public void Editor_Mod(string Codes)
        {
            this.CKCodes = Codes;
        }

        private void BAS_存货设置_选择仓库_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.button2.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in this.dbGridView.Rows)
            {
                if (Row.Cells["选择"].Value.ToBooleanDef())
                {
                    this.CKCodes += Row.Cells["仓库编码"].Value.ToString() + ",";
                    this.CKNames += Row.Cells["仓库名称"].Value.ToString() + ",";
                }
            }
            this.CKCodes = this.CKCodes.TrimEnd(',');
            this.CKNames = this.CKNames.TrimEnd(',');
            //
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void BAS_存货设置_选择仓库_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in this.dbGridView.Rows)
            {
                Row.Cells["选择"].Value = this.CKCodes.Contains(Row.Cells["仓库编码"].Value.ToString());
            }
            //
            this.CKCodes = "";
        }
    }
}

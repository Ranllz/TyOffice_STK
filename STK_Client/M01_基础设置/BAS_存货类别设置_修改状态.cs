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
    public partial class BAS_存货类别设置_修改状态 : Form
    {
        public BAS_存货类别设置_修改状态()
        {
            InitializeComponent();
            //         
            this.DataBinding_cbx类别状态();
        }

        private void DataBinding_cbx类别状态()
        {
            DataTable dt = null;
            //
            var model = new Ref_WS_STK.DataType_存货_类别();
            model.ExAction = "LBZT";
            AppServer.UsingWcf(() =>
            {
                dt = AppServer.wcfClient.BAS_存货_类别_List(model).Tables[0];
            });
            //
            this.cbx类别状态.ValueMember = "ID";
            this.cbx类别状态.DisplayMember = "类别状态名称";
            this.cbx类别状态.DataSource = dt;
            //
            this.cbx类别状态.SelectedIndex = 0;
        }

        public void Editor_Mod(DataRow dr)
        {
            this.Text = String.Format("修改类别状态【{0}】", dr["类别名称"].ToString());
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(dr, this);
            this.txt类别名称.Tag = dr["类别编码"].ToString();
        }

        public int SelectState { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.SelectState = this.cbx类别状态.SelectedValue.ToIntegerDef();
            //
            if (!AppServer.DialogMsg("确认要修改当前类别的状态吗?")) return;
            //
            if (this.SelectState == 3)
            {
                if (!AppServer.DialogMsg("当前类别下架后，此类别的下级类别及其所属商品将一块下架，确认要进行?")) return;
            }
            //
            var model = new Ref_WS_STK.DataType_存货_类别();
            model.ExAction = "Mod_ZT";
            model.类别编码 = this.txt类别名称.Tag.ToString();
            model.类别状态 = this.SelectState;
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.BAS_存货_类别_Edit(ref model);
            });
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_Error(model.ErrorMsg);
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

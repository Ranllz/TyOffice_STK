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
    public partial class BAS_存货设置_修改状态 : Form
    {
        public int Value = 0;
        //
        public BAS_存货设置_修改状态()
        {
            InitializeComponent();
            //
            this.DataBinding_cbx类别状态();
            //
            this.Text = "修改存货状态";
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
            this.cbx存货状态.ValueMember = "ID";
            this.cbx存货状态.DisplayMember = "类别状态名称";
            this.cbx存货状态.DataSource = dt;
        }

        public void Editor_Mod(DataGridViewRow Row)
        {
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(Row, this);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Value = this.cbx存货状态.SelectedValue.ToIntegerDef();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

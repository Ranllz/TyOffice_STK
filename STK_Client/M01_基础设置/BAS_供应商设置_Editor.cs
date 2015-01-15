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
    public partial class BAS_供应商设置_Editor : Form
    {
        public BAS_供应商设置_Editor()
        {
            InitializeComponent();
            //
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 11, this.btnOk, true);
        }
      
        public void Editor_Add()
        {
            this.btnOk.Tag = "Add";
            this.Text = "供应商设置--增加";            
        }

        public void Editor_Mod(DataGridViewRow Row)
        {
            this.btnOk.Tag = "Mod";
            this.Text = "供应商设置--修改";
            this.Tag = Row.Cells["供应商编码"].Value.ToString();
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(Row, this);            
        }

        private void BAS_供应商设置_Editor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnCancel.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnOk.PerformClick();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txt供应商名称.Text))
            {
                AppServer.ShowMsg("供应商名称不能为空，请填写！");
                this.lbl供应商名称33.BackColor = Color.Red;
                this.txt供应商名称.Focus();
                return;
            }
            //         
            var model = new Ref_WS_STK.DataType_供应商();
            this.DataBinding_DataSourceToModel(model);
            model.ExAction = this.btnOk.Tag.ToString();
            model.LoginUserCode = AppServer.LoginUserCode;
            model.供应商编码 = this.Tag.ToStringDef();
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.BAS_供应商_Edit(ref model);
            });
            //
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                return;
            }     
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

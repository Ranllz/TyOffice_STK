using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace STK_Client.Main
{
    public partial class Man_UserMngr_Editor : Form
    {
        public Man_UserMngr_Editor()
        {
            InitializeComponent();         
        }

        //增加状态
        public void Editor_Add()
        {
            this.Text = "新建用户";
            this.Tag = "Add";
            this.cbxUserState.SelectedIndex = 0;
            //
            this.txtUserCode.Focus();
        }

        //修改状态
        public void Editor_Mod(string AUserCode, DataView dv)
        {
            this.Text = "修改用户";
            this.Tag = "Mod";
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(dv, this);
            this.chk采购员.Checked = dv[0]["工作岗位"].ToString().IndexOf("采购员", 0) >= 0;
            this.chk销售员.Checked = dv[0]["工作岗位"].ToString().IndexOf("销售员", 0) >= 0;

            this.cbxUserState.SelectedIndex = dv[0]["UserState"].ToString().ToIntegerDef(0);
            //this.txtUserCode.ReadOnly = true;
            this.txtUserCode.Tag = this.txtUserCode.Text;
            this.txtUserName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtUserCode.Text.Trim() == "")
            {
                AppServer.ShowMsg_Warn("用户账号不能为空　　", "数据验证");
                this.txtUserCode.Focus();
                return;
            }
            if (this.txtUserName.Text.Trim() == "")
            {
                AppServer.ShowMsg_Warn("用户名称不能为空　　", "数据验证");
                this.txtUserName.Focus();
                return;
            }
            //
            this.DialogResult = DialogResult.None;
            try
            {
                var model = new Ref_WS_STK.DataType_User();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.UserState = this.cbxUserState.SelectedIndex;
                if (model.ExAction == "Mod")
                {
                    model.UserCode = this.txtUserCode.Tag.ToString();
                    model.NewUserCode = this.txtUserCode.Text;
                }
                //组合生成工作岗位
                StringBuilder sb = new StringBuilder();
                if (this.chk采购员.Checked) sb.Append("采购员");
                if (this.chk销售员.Checked)
                {
                    if (sb.Length > 1) sb.Append("，");
                    sb.Append("销售员");
                }
                model.工作岗位 = sb.ToString();
                
                if (!AppServer.WcfService_Open()) return;

                AppServer.wcfClient.Sys_User_Edit(ref model);

                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    switch (model.ExResult)
                    {
                        case 1: this.txtUserCode.Focus(); break;
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
            //提交成功了
            this.DialogResult = DialogResult.OK;
        }

    }
}

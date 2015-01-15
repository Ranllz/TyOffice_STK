using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STK_Client.Main
{
    public partial class Man_UserPswd : Form
    {
        public Man_UserPswd()
        {
            InitializeComponent();
        }

        private void Man_UserPass_Load(object sender, EventArgs e)
        {
            this.txt用户名称.Text = string.Format("({0}){1}", AppServer.LoginUserCode, AppServer.LoginUserName);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            if (this.txt新设密码.Text != this.txt确认密码.Text)
            {
                AppServer.ShowMsg_Warn("新设密码与确认密码不一致，请重新输入！", "密码对比");
                this.txt新设密码.Focus();
                return;
            }

            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var dtm = new Ref_WS_STK.DataType_User();
                dtm.ExAction = "ModPswd";
                dtm.UserCode = AppServer.LoginUserCode;
                dtm.UserPswd = this.txt当前密码.Text;
                dtm.NewUserPswd = this.txt新设密码.Text;

                AppServer.wcfClient.Sys_User_Edit(ref dtm);

                if (dtm.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(dtm.ErrorMsg);
                    if (dtm.ExResult == 1) this.txt当前密码.Focus();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Common;

namespace STK_Client
{
    public partial class Man_Login : Form
    {
        public Man_Login()
        {
            InitializeComponent();
            //
            this.Text = "用户登陆【" + Man_About.AssemblyAppVer + "】";
        }

        private void TfmMan_Login_Load(object sender, EventArgs e)
        {
            //
            if (Properties.Settings.Default.LoginRemb == true)
            {
                this.txtLoginName.Text = Properties.Settings.Default.LoginName;
                this.txtLoginPswd.Text = Cmn_DataProtection.UnprotectData(Properties.Settings.Default.LoginPswd);
                this.chkRemember.Checked = true;
                this.btnLogin.Focus();
            }
            else
            {
                this.txtLoginName.Focus();
            }
        }

        public void LoginType(Boolean AFirst = false)
        {
            if (AFirst == false)
            {
                this.Text = "切换操作员";
                this.btnExit.Text = "返回(&X)";
            }
        }

        private void txtLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13)) this.txtLoginPswd.Focus();
        }

        private void txtLoginPswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) this.btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            if (this.txtLoginName.Text.Trim().Length == 0) 
            {
                AppServer.ShowMsg("请输入要登录的用户账号！");
                this.txtLoginName.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            //开始验证登录
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_STK.DataType_User();
                model.LoginName = this.txtLoginName.Text;
                model.LoginPswd = this.txtLoginPswd.Text;
                model.LoginDate = this.dtpLoginDate.Value;
                model.LoginAddr = TY.Common.NetWork.GetLocalIP();
                model.LoginID = AppServer.LoginID;  //重新登录时会用于注册退出使用
                
                AppServer.wcfClient.SYS_Login(ref model);

                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(model.ErrorMsg, "登录失败了！");
                    switch (model.ExResult)
                    {
                        case 1: this.txtLoginName.Focus(); break;
                        case 2: this.txtLoginPswd.Focus(); break;
                        case 3: this.dtpLoginDate.Focus(); break;
                    }                    
                    return;
                }
                AppServer.LoginUserCode = model.UserCode;
                AppServer.LoginUserName = model.UserName;
                AppServer.LoginWorkDate = this.dtpLoginDate.Value;
                AppServer.LoginID = model.LoginID;
                //获取用户菜单列表
                DataSet tdb = AppServer.wcfClient.SYS_Login_Menu(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(model.ErrorMsg, "登录失败了！");
                    return;
                }
                if (AppServer.UserQxMenuList != null) AppServer.UserQxMenuList.Dispose();
                AppServer.UserQxMenuList = tdb.Tables[0].Copy();
                AppServer.UserQxMenuList.PrimaryKey = new DataColumn[1] { AppServer.UserQxMenuList.Columns["MenuCode"] };
                //获取系统参数
                AppServer.wcfClient.SYS_Param_Get(ref AppServer.Sys_Param);
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_Error("系统登录时出现异常，请确认您的网络连接是否有问题！\n错误信息：" + ex.Message, "登录失败了！");
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;            
            }

            //登录成功了
            if (this.chkRemember.Checked)
            {
                Properties.Settings.Default.LoginName = this.txtLoginName.Text;
                Properties.Settings.Default.LoginPswd = Cmn_DataProtection.ProtectData(txtLoginPswd.Text, "GLG_STK_Password");
                Properties.Settings.Default.LoginRemb = this.chkRemember.Checked;
            }
            else
            {
                Properties.Settings.Default.LoginName = string.Empty;
                Properties.Settings.Default.LoginPswd = string.Empty;
                Properties.Settings.Default.LoginRemb = this.chkRemember.Checked;
            }
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
        }

    }
}

#undef DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Controls;
using STK_Client.Main;
using TY.Helper;


namespace STK_Client
{
    public partial class Man_Main : Form
    {
        
        private bool FLoginSuccess;
        private MdiClient m_MdiClient;

        public Man_Main()
        {
            InitializeComponent();

            #region MDI窗口事件处理
            foreach (Control control in this.Controls)
            {
                if (control.GetType().ToString() == "System.Windows.Forms.MdiClient")
                {
                    m_MdiClient = (MdiClient)control;
                    break;
                }
            }
            //m_MdiClient.BackColor = System.Drawing.SystemColors.Control;
            m_MdiClient.ControlAdded += new ControlEventHandler(m_MdiClient_ControlAdded);
            m_MdiClient.ControlRemoved += new ControlEventHandler(m_MdiClient_ControlRemoved);
            #endregion
#if DEBUG
            AppServer.LoginUserCode = "000";
#endif
            //应用程序初始化
            AppServer.InitAppServer(this);
            //用户登录
            FLoginSuccess = this.Login(true);
            if (!FLoginSuccess) return;
        }

       
        public Boolean Login(Boolean AFirst = false)
        {
            bool bLogined = false;
            if (!string.IsNullOrWhiteSpace(AppServer.LoginUserCode) && AFirst)
            {
                var model = new Ref_WS_STK.DataType_User();
                model.ExAction = "OA";
                model.LoginName = AppServer.LoginUserCode;
                AppServer.UsingWcf(() =>
                {
                    AppServer.wcfClient.SYS_Login(ref model);
                });
                if (model.ExResult == 0)
                {
                    AppServer.LoginUserCode = model.UserCode;
                    AppServer.LoginUserName = model.UserName;
                    AppServer.LoginWorkDate = DateTime.Now;
                    AppServer.LoginID = model.LoginID;
                    //获取用户菜单列表
                    AppServer.UsingWcf(() =>
                   {
                       DataSet tdb = AppServer.wcfClient.SYS_Login_Menu(ref model);

                       if (model.ExResult != 0)
                       {
                           bLogined = false;
                       }
                       else
                       {
                           if (AppServer.UserQxMenuList != null) AppServer.UserQxMenuList.Dispose();
                           AppServer.UserQxMenuList = tdb.Tables[0].Copy();
                           AppServer.UserQxMenuList.PrimaryKey = new DataColumn[1] { AppServer.UserQxMenuList.Columns["MenuCode"] };
                           //获取系统参数
                           AppServer.wcfClient.SYS_Param_Get(ref AppServer.Sys_Param);
                           bLogined = true;
                       }
                   });
                }
            }
            //
            if (!bLogined)
            {
                using (var fLogin = new Man_Login())
                {
                    fLogin.Visible = false;
                    fLogin.LoginType(AFirst);
                    if (fLogin.ShowDialog() != DialogResult.OK)
                    {
                        //登录失败了，直接返回
                        return false;
                    }
                    //登录成功了
                    base.Cursor = Cursors.WaitCursor;
                }
            }
            //
            try
            {
                //更新界面属性
                this.Text = string.Format("{0} {1}", AppServer.Sys_Param.AppName, Man_About.AssemblyAppVer);
                this.toolStripLabelTitle.Text = string.Format("『{0}』的功能树", AppServer.LoginUserName);
                this.tsslAppHost.Text = string.Format("应用服务器：{0}", AppServer.wcfClient.Endpoint.Address.Uri.Host.ToString());
                this.tsslWorkDate.Text = string.Format("业务日期：{0:yyyy-MM-dd}", AppServer.LoginWorkDate);
                this.tsslLoginUser.Text = string.Format("  操作员：({0}){1}  ", AppServer.LoginUserCode, AppServer.LoginUserName);
                this.tsslAppUnit.Text = string.Format("  公司名称：{0}", AppServer.Sys_Param.公司名称);

                //创建用户功能树
                if (AppServer.UserQxMenuList != null)
                {
                    //DataView dv = new DataView(AppServer.UserQxMenuList);
                    //dv.RowFilter = "MenuType=0 or MenuType=1";
                    DataTable dt = AppServer.UserQxMenuList.Clone();
                    foreach (DataRow row in AppServer.UserQxMenuList.Select("MenuType=0 or MenuType=1", "MenuPCode, MenuOrder, MenuCode"))
                    {
                        dt.Rows.Add(row.ItemArray);
                    }
                    this.dbTreeView.DataSource = dt; // AppServer.UserQxMenuList;
                    this.dbTreeView.BuildTrees();
                }
                //重新登录后要把子窗口全部关闭
                if (!AFirst)
                {
                    foreach (Form fMDI in this.MdiChildren)
                    {
                        fMDI.Close();
                    }
                }
                //返回成功登录了
                return true;
            }
            finally
            {
                base.Cursor = Cursors.Arrow;
            }
            
        }

        public void UpdateForm(bool ABuildTree = true)
        {

        }

        private void fmMan_Main_Load(object sender, EventArgs e)
        {
            if (!FLoginSuccess) return;
            this.toolBtnShowFT.PerformClick();
        }
        
        private void TfmMan_Main_Shown(object sender, EventArgs e)
        {
            if (!FLoginSuccess) this.Close();
        }

        private void TfmMan_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            if (!FLoginSuccess) return;
            //退出提示
#if !DEBUG
            if (AppServer.DialogMsg("感谢您的使用，确认要退出系统吗？", "退出提示"))
            {
                //开始验证登录
                base.Cursor = Cursors.WaitCursor;
                try
                {
                    if (!AppServer.WcfService_Open()) return;
                    //
                    var model = new Ref_WS_STK.DataType_User();
                    model.LoginID = AppServer.LoginID;
                    AppServer.wcfClient.SYS_Logout(model);
                    if (model.ExResult != 0)
                    {
                        AppServer.ShowMsg_Error(model.ErrorMsg, "退出登录注册失败了！");
                        return;
                    }
                }
                catch
                {
                    return;
                }
                finally
                {
                    AppServer.WcfService_Close();
                    base.Cursor = Cursors.Arrow;
                }
            }
            else
            {
                e.Cancel = true;
            }
#endif
        }

        #region MDIFormList控制
        Random random = new Random();
        private void m_MdiClient_ControlAdded(object sender, ControlEventArgs e)
        {
            //将控件添加到控件集合时
            Button button = new Button();
            button.Dock = DockStyle.Bottom;
            button.FlatStyle = FlatStyle.Popup;
            button.Text = e.Control.Text;

            e.Control.Tag = "Form" + random.Next().ToString();
            button.Name = "Button" + e.Control.Tag;
            button.UseVisualStyleBackColor = true;
            //button.Click += new EventHandler(button_Click);
            button.Click += delegate(object o, EventArgs y)
            //委托 匿名函数 目的是解决传参数
            {
                foreach (Form childForm in MdiChildren)
                {
                    if (childForm.Tag == e.Control.Tag)
                    {
                        childForm.Focus();
                        break;
                    }
                }
            };
            pnlLeft.Controls.Add(button);
        }

        private void m_MdiClient_ControlRemoved(object sender, ControlEventArgs e)
        {
            //++++++++++++++++++ 将控件从控件集合移除时 ++++++++++++++++++
            //MessageBox.Show(e.Control.Name);
            foreach (Control control in pnlLeft.Controls)
            {
                if (control.Name == "Button" + e.Control.Tag)
                {
                    pnlLeft.Controls.Remove(control);
                    control.Dispose();
                    break;
                }
            }
        }
        #endregion
        
        #region 菜单功能调用实现

        private void miChangYear_Click(object sender, EventArgs e)
        {

        }

        private void miModiPswd_Click(object sender, EventArgs e)
        {
            //修改密码
            using (Man_UserPswd form = new Man_UserPswd())
            {
                form.Visible = false;
                form.ShowDialog();
            }
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            //用户登录
            this.Login(false);
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            //退出系统
            this.Close();
        }

        private void miView_FunctionTree_Click(object sender, EventArgs e)
        {
            //菜单→窗口→功能树
            if (miView_FunctionTree.Checked)
                this.toolBtnShowFT.PerformClick();
            else
                this.toolBtnHideFT.PerformClick();
        }

        private void miView_StatusBar_Click(object sender, EventArgs e)
        {
            //菜单→视图→状态栏
            this.statusStrip1.Visible = this.miView_StatusBar.Checked;
        }

        private void miTool_Calc_Click(object sender, EventArgs e)
        {
            //菜单→工具→计算器
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName("calc");
            if (p.Length <= 0)
                System.Diagnostics.Process.Start("calc.exe ");
            else Win32.SetForegroundWindow(p[0].MainWindowHandle);
        }

        private void miTool_Note_Click(object sender, EventArgs e)
        {
            //菜单→工具→记事本
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName("notepad");
            if (p.Length <= 0)
                System.Diagnostics.Process.Start("notepad.exe ");
            else Win32.SetForegroundWindow(p[0].MainWindowHandle);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→排列图标
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→层叠
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→水平平铺
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→垂直平铺
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→全部关闭
            foreach (Form fMdiForm in this.MdiChildren)
            {
                fMdiForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Man_About fAbout = new Man_About())
            {
                fAbout.ShowDialog();
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            //折叠功能树
            this.pnlLeft.Visible = false;
            this.pnlRight.Visible = true;
            this.splitter.Enabled = false;
            this.splitter.Visible = false;
            this.miView_FunctionTree.Checked = false;
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            //展开功能树
            this.pnlRight.Visible = false;
            this.pnlLeft.Visible = true;
            this.splitter.Enabled = true;
            this.splitter.Visible = true;
            this.miView_FunctionTree.Checked = true;
        }

        private void labelTree_Click(object sender, EventArgs e)
        {
            this.toolBtnShowFT.PerformClick();
        }

        #endregion

        #region 用户功能菜单树调用实现

        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 0;
            }
            else
            {
                e.Node.ImageIndex = 2;
                e.Node.SelectedImageIndex = 0;
            }
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (((DBTreeNode)e.Node).ID)
            {
                case "0991": {this.miLogin.PerformClick(); break; }
                case "0992": {this.miExit.PerformClick(); break; }
                default :
                    {
                        AppServer.OpenUserMenu(((DBTreeNode)e.Node).ID, ((DBTreeNode)e.Node).Text);
                        break;
                    }

            }
        }

        #endregion

    }
}

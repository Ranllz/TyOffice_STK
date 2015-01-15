using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using System.Data;
using System.Drawing;
using Microsoft.Win32;
using TY.Controls;
using System.ServiceModel;
using STK_Client.Main;
using STK_Client.M01_基础设置;
using STK_Client.M02_库存管理;
using STK_Client.M03_期末管理;
using STK_Client.M04_库存报表;

namespace STK_Client
{
    class Win32
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        [DllImport("kernel32.dll")]
        public static extern void Sleep(int dwMilliseconds);

        [DllImport("user32.dll ")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }

    public class AppServer
    {
        #region 全局变量

        //当前用户编码
        public static string LoginUserCode;
        //当前用户名称
        public static string LoginUserName;
        //登录业务日期
        public static DateTime LoginWorkDate;
        //登录业务日期
        public static DateTime 会计期间_B;
        //登录业务日期
        public static DateTime 会计期间_E;
        //登录后返回的ID
        public static int LoginID = 0;

        //用户权限表
        public static DataTable UserQxMenuList = null;

        //系统参数
        public static Ref_WS_STK.DataType_Param Sys_Param = new Ref_WS_STK.DataType_Param();

        public static int ReadRows = 500;

        public static string PrintUnitName
        {
            get { return "单位：" + AppServer.Sys_Param.公司名称; }
        }

        public static Form MainForm;
        public static Form CurrentForm;

        #endregion

        #region 公用函数  几个不同的提示消息方法
        public static void ShowMsg(string AMsgText, string AMsgCapt = "提示")
        {
            MessageBox.Show(AMsgText, AMsgCapt, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowMsg_Warn(string AMsgText, string AMsgCapt = "警告")
        {
            MessageBox.Show(AMsgText, AMsgCapt, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowMsg_Error(string AMsgText, string AMsgCapt = "错误")
        {
            MessageBox.Show(AMsgText, AMsgCapt, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool DialogMsg(string AMsgText, string AMsgCapt = "询问")
        {
            return (MessageBox.Show(AMsgText, AMsgCapt, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }
        public static void ShowMsg_InputWarn(string AHintInfo)
        {
            MessageBox.Show(AHintInfo, "数据验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowMsg_SubmitError(string AErrorMessage)
        {
            MessageBox.Show("提交数据时返回执行错误！\n错误信息：" + AErrorMessage, "提交错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowMsg_ExceptError(string AErrorMessage, string ASource="")
        {
            MessageBox.Show(ASource+"执行过程中出现异常错误了！\n错误信息：" + AErrorMessage, "异常错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region WCF服务连接

        public static Ref_WS_STK.WS_STKClient wcfClient = null;
        public static System.ServiceModel.Channels.Binding wcfBinding = null;
        public static System.ServiceModel.EndpointAddress wcfEndPointAddress = null;

        public static System.ServiceModel.Channels.Binding wcfBinding_File = null;
        public static System.ServiceModel.EndpointAddress wcfEndPointAddress_File = null;

        public static string ReportURL;
        public static string ReportPath;
        public static string ReportUsername;
        public static string ReportPassword;

        public static void InitAppServer(Form AMainForm)
        {
            AppServer.MainForm = AMainForm;

            //BindingHelper.Init();
            //读取Http通道的配置
            //BindingHelper.InitBindingInfo("BasicHttpBinding_IWS_GBJY", out wcfBinding, out wcfEndPointAddress);
            //读取Net.Tcp通道的配置
            //BindingHelper.InitBindingInfo("NetTcpBinding_IWS_FileTrans", out wcfBinding_File, out wcfEndPointAddress_File);
            //读取报表服务器的配置
            //BindingHelper.ReadReportMachineInfo(out ReportURL, out ReportPath, out ReportUsername, out ReportPassword);
        }

        public static Boolean WcfService_Open()
        {
            try
            {
                if ((wcfClient == null)
                    || (wcfClient.State != System.ServiceModel.CommunicationState.Created)
                    || (wcfClient.State != System.ServiceModel.CommunicationState.Opened))
                {
                    wcfClient = new Ref_WS_STK.WS_STKClient("BasicHttpBinding_IWS_STK");
                    //wcfClient = new WS_STKClient(wcfBinding, wcfEndPointAddress);
                }
                return true;
            }
            catch (Exception ex)
            {
                //经验证此时URL不对也能正常创建啊，没异常错误，调用具体方法时才出错的
                AppServer.ShowMsg_SubmitError("打开Wcf出现异常！ 错误信息：" + (char)13 + ex.Message);
                return false;
            }
        }

        public static bool UsingWcf(Action action)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return false;

                action();

                return true;
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return false;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
        }

        public static void WcfService_Close()
        {
            try
            {
                if (wcfClient.State != System.ServiceModel.CommunicationState.Faulted)
                    wcfClient.Close();
            }
            catch
            {
                wcfClient.Abort();
            }
        }

        public static decimal ReadDecimal(DataGridViewCell cell)
        {
            return decimal.Parse(cell.Value.ToString() == "" ? "-1" : cell.Value.ToString());
        }

        public static decimal ReadDecimal(object cell)
        {
            return decimal.Parse(cell.ToString() == "" ? "-1" : cell.ToString());
        }

        // 读取表格定义
        public static string GetTableDef(string tableid)
        {
            if (AppServer.wcfClient.State == System.ServiceModel.CommunicationState.Opened) 
            {
                // 已经打开则不再关闭
                return AppServer.wcfClient.GetTableDef(tableid);
            }
            else 
            {
                // 否则先打开后关闭
                try
                {
                    if (!AppServer.WcfService_Open()) return "";
                    //
                    return AppServer.wcfClient.GetTableDef(tableid);   
                }
                catch (Exception ex)
                {
                    AppServer.ShowMsg_ExceptError(ex.Message);
                    return "";
                }
                finally
                {
                    AppServer.WcfService_Close();
                }
            }
        }

        #endregion

        #region 单元格显示格式
        public static void SetGridViewStyle(DataGridView grid)
        {
            //设置表格显示颜色配置
            grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(AppServer.GridView_CellFormatting);
            //不允许自动增加列
            grid.AutoGenerateColumns = false;
        }


        public static void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.Orange;
            e.CellStyle.SelectionForeColor = Color.Black;
            if (e.RowIndex % 2 == 1)
            {
                e.CellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }
        }
        #endregion

        #region Cmn_WaitingBox
        public static Cmn_WaitingBox formWaitingBox = null;
        public static void Sleep(int dwMilliseconds)
        {
            Win32.Sleep(dwMilliseconds);
        }

        public static void SetWindowTop(int hwnd, bool top)
        {
            int hWndInsertAfter = 0;

            if (top)
                hWndInsertAfter = -1;   // 置顶
            else
                hWndInsertAfter = -2;   // 解除置顶

            Win32.SetWindowPos(hwnd, hWndInsertAfter, 0, 0, 0, 0, 0x001 | 0x002 | 0x040);
        }

        public static void SetWindowTop(Form form, bool top)
        {
            SetWindowTop(form.Handle.ToInt32(), top);
        }

        public delegate void OnFormShow();
        public static OnFormShow ShowWaitForm = delegate()
        {
            if (formWaitingBox == null) formWaitingBox = new Cmn_WaitingBox();
            formWaitingBox.ShowMsg();
        };

        public delegate void OnFormClose();
        public static OnFormClose HideWaitForm = delegate()
        {
            if (formWaitingBox != null)
            {
                formWaitingBox.Close();
                formWaitingBox = null;
            }
        };

        public delegate void OnDataImport(string msg, int progress, int max, bool waiting);
        public static OnDataImport DataImport = delegate(string msg, int progress, int max, bool waiting)
        {
            formWaitingBox.MsgText = msg;
            formWaitingBox.ProgressMax = max;
            formWaitingBox.Progress = progress;
            if (waiting) { AppServer.Sleep(100); }
        };
        #endregion

        #region Wcf服务的简洁调用
        public static TReturn WcfService<TChannel, TReturn>(Func<TChannel, TReturn> func)
        {
            var chanFactory = new ChannelFactory<TChannel>("*");
            TChannel channel = chanFactory.CreateChannel();
            ((IClientChannel)channel).Open();
            TReturn result = func(channel);
            try
            {
                ((IClientChannel)channel).Close();
            }
            catch (Exception ex)
            {
                ((IClientChannel)channel).Abort();
                ShowMsg_ExceptError(ex.Message);
            }
            return result;
        }
        #endregion

        #region 菜单调用处理方法

        public static bool OpenUserMenu(string AMenuCode, string AMenuName)
        {
            if (!AppServer.UserQxMenuList.Rows.Contains(AMenuCode))
            {
                AppServer.ShowMsg_Warn(string.Format("对不起，您没有“{0}”模块的操作权限，请与系统管理员联系解决！", AMenuName), "权限验证");
                return false;
            }
            //已打开的就不再重复创建了
            foreach (Form fForm in Application.OpenForms)
            {
                if (fForm.Name == AMenuName)
                {
                    fForm.BringToFront();
                    return true;
                }
            }
            //开始创建表单
            Form fMdiForm = null;
            switch (AMenuCode)
            {
                #region 基础设置-01
                case "0101": { fMdiForm = new BAS_仓库设置(); break; }
                case "0102": { fMdiForm = new BAS_货架设置(); break; }
                case "0103": { fMdiForm = new BAS_储物箱设置(); break; }
                case "0104": { fMdiForm = new BAS_供应商设置(); break; }
                case "0105": { fMdiForm = new BAS_存货类别设置(); break; }
                case "0106": { fMdiForm = new BAS_存货设置(); break; }
                case "0107": { fMdiForm = new BAS_期初库存设置(); break; }
                //case "0108": { fMdiForm = new BAS_存货出库单价设置(); break; }     
                #endregion

                #region 库存管理-02
                case "0201":
                    {
                        var fm = new STK_库存入库_Editor();
                        fm.Editor_Add();
                        fm.ShowDialog();
                        break;
                    }
                case "0202":
                    {
                        var fm = new STK_库存出库_Editor();
                        fm.Editor_Add();
                        fm.ShowDialog();
                        break;
                    }
                //case "0206":
                //    {
                //        var fm = new M01_申请单_Edit();
                //        fm.Editor_Add(2);
                //        fm.ShowDialog();
                //        break;
                //    }
                case "0207": { fMdiForm = new STK_库存入库(); break; }
                case "0208": { fMdiForm = new STK_库存出库(); break; }
                #endregion
                #region 期末管理-03
                case "0301": { fMdiForm = new STK_期末结账(); break; }
                //case "0303": { fMdiForm = new Bas_盘点(); break; }
                #endregion
                #region 库存报表-04
                case "0501": { fMdiForm = new STK_库存分布(); break; }
                //case "0402": { fMdiForm = new Bas_出入库信息记录(); break; }
                case "0503": { fMdiForm = new STK_库存总账(); break; }
                #endregion

                #region 系统管理-09
                case "0901": { (new Man_Param()).ShowDialog(); break; }
                case "0902": { fMdiForm = new Man_UserMngr(); break; }
                case "0903": { (new Man_UserPswd()).ShowDialog(); break; }
                #endregion
            }
            //
            if (fMdiForm != null)
            {
                fMdiForm.Name = AMenuName;
                fMdiForm.Text = AMenuName;
                fMdiForm.MdiParent = AppServer.MainForm;
                fMdiForm.WindowState = FormWindowState.Maximized;
                fMdiForm.Show();
                fMdiForm.BringToFront();

                AppServer.CurrentForm = fMdiForm;
            }
            //调用成功了
            return true;
        }
        #endregion
    }

}

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
    public partial class Man_Param : Form
    {
        public Man_Param()
        {
            InitializeComponent();
        }

        private void Man_Param_Load(object sender, EventArgs e)
        {
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(AppServer.Sys_Param, this);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtAppName.Text.Length < 5)
            {
                AppServer.ShowMsg_Error("应用程序名称必须大于5个字以上吧！");
                return;
            }
            string sOldName = AppServer.Sys_Param.AppName;
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, AppServer.Sys_Param);

            //
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_STK.DataType_Param();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);

                AppServer.wcfClient.SYS_Param_Set(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //
                AppServer.ShowMsg("系统参数设置成功了！", "成功提示");
                if (!sOldName.Equals(AppServer.Sys_Param.AppName))
                    AppServer.ShowMsg("应用程序名称的设置需要重新启动程序以后才能生效！", "提示");
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
            //
            this.DialogResult = DialogResult.OK;
        }
    }
}

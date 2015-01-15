using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Collections.Specialized;
using System.Web;
using STK_Client.M01_基础设置;

namespace STK_Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.ActivationUri != null)
            {
                //检查URL参数
                NameValueCollection col = new NameValueCollection();
                string queryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
                col = HttpUtility.ParseQueryString(queryString);
                AppServer.LoginUserCode = col["LoginUserID"];
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Man_Main());
            
        }
    }
}

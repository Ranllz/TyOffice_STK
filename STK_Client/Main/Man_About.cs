using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;


namespace STK_Client
{
    public partial class Man_About : Form
    {
        public Man_About()
        {
            InitializeComponent();
        }

        private void FrmMan_About_Load(object sender, EventArgs e)
        {
            //this.Text = String.Format("关于 {0} ", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("版本 {0} ( {1} )", AssemblyVersion, AssemblyFileVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;

            this.textBoxDescription.AppendText("\r\n\r\n数据库版本：" + AppServer.Sys_Param.DBVersion);
            this.textBoxDescription.AppendText("\r\n\r\n中间层版本：" + AppServer.Sys_Param.WSVersion);
        }

        #region 程序集属性访问器

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyFileVersion
        {
            get
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(asm.Location);
                return fvi.FileVersion;
            }
        }

        public static string AssemblyAppVer
        {
            get
            {
                if (Assembly.GetExecutingAssembly().GetName().Version.Build == 0)
                {
                    return string.Format("Ver{0}.{1}",
                        Assembly.GetExecutingAssembly().GetName().Version.Major,
                        Assembly.GetExecutingAssembly().GetName().Version.Minor);
                }
                else
                {
                    return string.Format("Ver{0}.{1}.{2}",
                        Assembly.GetExecutingAssembly().GetName().Version.Major,
                        Assembly.GetExecutingAssembly().GetName().Version.Minor,
                        Assembly.GetExecutingAssembly().GetName().Version.Build);
                }
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}

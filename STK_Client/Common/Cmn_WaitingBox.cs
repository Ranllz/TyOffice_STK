using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STK_Client
{
    public partial class Cmn_WaitingBox : Form
    {
        public Cmn_WaitingBox()
        {
            InitializeComponent();
        }

        public void ShowMsg()
        {
            this.Show();
            AppServer.SetWindowTop(this, true);
            this.Refresh();
        }

        public int ProgressMax
        {
            set { this.progressBar.Maximum = value; }
        }

        public int Progress
        {
            set
            {
                this.progressBar.Value = value;
            }
        }

        public string MsgText
        {
            set
            {
                this.lblMsg.Text = value;// +(char)10;
                this.lblMsg.Refresh();
            }
        }
    }
}

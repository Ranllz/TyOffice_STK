using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STK_Client.M03_期末管理
{
    public partial class STK_期末结账_Select : Form
    {
        public string PCKCode = "";
        //
        public STK_期末结账_Select()
        {
            InitializeComponent();
            //
            
            this.DataBinding_cbx仓库编码();
        }

        public void SetValue(string Period)
        {
            this.lbl会计期间.Text = Period;
            this.Text = "结账  " + Period;
        }

        private void DataBinding_cbx仓库编码()
        {
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "AllCK";
            AppServer.UsingWcf(() =>
            {
                this.cbx仓库编码.ValueMember = "仓库编码";
                this.cbx仓库编码.DisplayMember = "仓库名称";
                this.cbx仓库编码.DataSource = AppServer.wcfClient.BAS_仓库_List(model).Tables[0];
            });
            //
            if (this.cbx仓库编码.Items.Count > 0)
            {
                this.cbx仓库编码.SelectedIndex = 0;
            }
            else
            {
                this.cbx仓库编码.SelectedIndex = -1;
            }
        }

        private void btn选择_Click(object sender, EventArgs e)
        {
            if (this.cbx仓库编码.SelectedIndex == -1)
            {
                AppServer.ShowMsg("请选择结账仓库");
                return;
            }
            //
            this.PCKCode = (string)this.cbx仓库编码.SelectedValue;
            //
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

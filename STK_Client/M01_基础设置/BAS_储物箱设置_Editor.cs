using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace STK_Client.M01_基础设置
{
    public partial class BAS_储物箱设置_Editor : Form
    {
        private string CWXCode = "";
        private string SUPcode = "";
        //
        public BAS_储物箱设置_Editor()
        {
            InitializeComponent();
            //
            this.DataBinding_cbx仓库();
            //
            this.cbx仓库编码.SelectedIndexChanged += cbx仓库编码_SelectedIndexChanged;
        }

        public void Editor_Add()
        {
            this.Text = "新增储物箱";
            this.Tag = "Add";
        }

        public void Editor_Mod(DataGridViewRow Row)
        {
            this.Text = String.Format("修改储物箱信息-{0}", Row.Cells["仓库名称"].Value);
            this.Tag = "Mod";
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(Row, this);
            this.CWXCode = Row.Cells["仓库编码"].Value.ToString();
            this.cbx仓库编码.SelectedValue = Row.Cells["仓库编码"].Value.ToString().Substring(0, 3);
            this.cbx上级编码.SelectedValue = Row.Cells["仓库编码"].Value.ToString().Substring(0, 6);
            //储物箱编码一旦创建不允许修改，则在此不允许修改储物箱关联的仓库、货架
            this.cbx仓库编码.Enabled = false;
            this.cbx上级编码.Enabled = false;
        }

        private void BAS_储物箱设置_Editor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnCancel.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnEnter.PerformClick();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.txt仓库名称.Text.Trim() == string.Empty)
            {
                AppServer.ShowMsg_Warn("当前输入框不允许为空！");
                this.txt仓库名称.Focus();
            }
            try
            {
                Ref_WS_STK.DataType_仓库 model = new Ref_WS_STK.DataType_仓库();
                model.上级编码 = this.SUPcode;
                model.仓库编码 = this.CWXCode;
                model.LoginUserCode = AppServer.LoginUserCode;
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                AppServer.UsingWcf(() => 
                {
                    AppServer.wcfClient.BAS_储物箱_Edit(ref model);
                });
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void DataBinding_cbx仓库()
        {
            DataTable dt = null;
            //
            Ref_WS_STK.DataType_仓库 model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "ALLCK";
            AppServer.UsingWcf(() => 
            {
                dt = AppServer.wcfClient.BAS_仓库_List(model).Tables[0];
            }); 
            //
            this.cbx仓库编码.ValueMember = "仓库编码";
            this.cbx仓库编码.DisplayMember = "仓库名称";          
            this.cbx仓库编码.DataSource = dt;
            //
            if (this.cbx仓库编码.Items.Count > 0)
            {
                this.cbx仓库编码.SelectedIndex = 0;
            }
        }

        private void DataBinding_cbx货架()
        {
            Ref_WS_STK.DataType_仓库 model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "SLCHJ";
            model.上级编码 = this.cbx仓库编码.SelectedIndex > -1 ? (string)this.cbx仓库编码.SelectedValue : "";
            DataTable dt = null;
            AppServer.UsingWcf(() =>
            {
                dt = AppServer.wcfClient.BAS_货架_List(model).Tables[0];
            });
            this.cbx上级编码.DisplayMember = "仓库名称";
            this.cbx上级编码.ValueMember = "仓库编码";
            this.cbx上级编码.DataSource = dt;
            if (this.cbx上级编码.Items.Count == 0)
            {
                AppServer.ShowMsg_Warn("当前仓库尚未分配货架，请前往货架设置进行设置！");
                this.btnEnter.Enabled = false;
            }
            else { this.btnEnter.Enabled = true; }
        }

        private void cbx仓库编码_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_cbx货架();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STK_Client.M01_基础设置
{
    public partial class M02_仓库设置_Editor : Form
    {
        private string CKCode = "";
        //
        public M02_仓库设置_Editor()
        {
            InitializeComponent();
            //
            this.DataBinding_cbx仓管员();
        }

        private void DataBinding_cbx仓管员()
        {
            var model = new Ref_WS_STK.DataType_User();
            model.ExAction = "List";
            model.UserState = 0;
            AppServer.UsingWcf(() =>
            {
                this.cbx仓管员.ValueMember = "UserCode";
                this.cbx仓管员.DisplayMember = "UserName";
                this.cbx仓管员.DataSource = AppServer.wcfClient.Sys_User_List(model).Tables[0];
            });     
        }

        public void Editor_Add()
        {
            this.Text = "新增仓库";
            this.Tag = "Add";
        }

        public void Editor_Mod(DataGridViewRow Row)
        {
            this.Text = String.Format("修改仓库信息---{0}", Row.Cells["仓库名称"].Value);
            this.Tag = "Mod";
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(Row, this);
            if (Row.Cells["UserName"].Value.ToString() == "")
            {
                this.cbx仓管员.SelectedIndex = -1;
            }
            else
            {
                this.cbx仓管员.Text = Row.Cells["UserName"].Value.ToString();
            }
            this.CKCode = Row.Cells["仓库编码"].Value.ToString();
        }

        private void BAS_仓库设置_Editor_KeyUp(object sender, KeyEventArgs e)
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
            if (String.IsNullOrWhiteSpace(this.txt仓库名称.Text))
            {
                AppServer.ShowMsg("仓库名称不能为空或者空格");
                return;
            }
            //
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = this.Tag.ToString();
            model.仓库编码 = this.CKCode;
            model.LoginUserCode = AppServer.LoginUserCode;
            model.仓库负责人 = (string)this.cbx仓管员.SelectedValue;
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.BAS_仓库_Edit(ref model);
            });
            //
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_Error(model.ErrorMsg);
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

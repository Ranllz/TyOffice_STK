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
    public partial class BAS_货架设置_Editor : Form
    {
        // 接口声明
        public delegate void AddNewDataEvent(string value);
        // 接口定义
        public AddNewDataEvent OnAddNewDataEvent { get; set; }
        private string HJCode = "";
           
        //
        public BAS_货架设置_Editor()
        {
            InitializeComponent();
            //
            this.DataBinding_cbx仓库编码();
        }

        private void DataBinding_cbx仓库编码()
        {
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "AllCK";
            model.包含所有项 = 0;
            AppServer.UsingWcf(() =>
            {
                this.cbx上级编码.ValueMember = "仓库编码";
                this.cbx上级编码.DisplayMember = "仓库名称";
                this.cbx上级编码.DataSource = AppServer.wcfClient.BAS_仓库_List(model).Tables[0];
            });
        }

        public void Editor_Add()
        {
            this.Text = "新增货架";
            this.Tag = "Add";
            //
            this.txt仓库地址.Tag = "";
        }

        public void Editor_Mod(DataGridViewRow Row)
        {
            this.Text = String.Format("修改货架信息【{0}】", Row.Cells["仓库名称"].Value);
            this.Tag = "Mod";
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(Row, this);
            this.HJCode = Row.Cells["仓库编码"].Value.ToString();
            this.cbx上级编码.SelectedValue= Row.Cells["上级编码"].Value.ToString();
            //
            this.btnOK_Add.Visible = false;
            this.btnEnter.Location = new Point(this.btnEnter.Left - 60, this.btnEnter.Top);
            this.btnCancel.Location = new Point(this.btnCancel.Left + 60, this.btnEnter.Top);
        }

        private void BAS_货架设置_Editor_KeyUp(object sender, KeyEventArgs e)
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

        private bool PostData()
        {
            if (this.cbx上级编码.SelectedIndex == -1)
            {
                AppServer.ShowMsg_Warn("请选择货架所在仓库");
                return false;
            }
            if (String.IsNullOrWhiteSpace(this.txt仓库名称.Text))
            {
                AppServer.ShowMsg("货架名称不能为空或是全部空格");
                return false;
            }
            //
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = this.Tag.ToString();
            model.仓库编码 = this.HJCode;
            model.LoginUserCode = AppServer.LoginUserCode;
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.BAS_货架_Edit(ref model);
            });
            //
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_Error(model.ErrorMsg);
                return false;
            }
            if (this.OnAddNewDataEvent != null) this.OnAddNewDataEvent((string)this.cbx上级编码.SelectedValue);
            return true;         
        }

        private void btnOK_Add_Click(object sender, EventArgs e)
        {
            if (PostData())
            {
               // this.txt仓库名称.Text = "";
                this.txt仓库名称.SelectAll();
                this.txt仓库名称.Focus();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (PostData())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}

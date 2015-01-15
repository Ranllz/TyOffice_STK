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
    public partial class BAS_存货类别设置_Editor : Form
    {
        // 接口声明
        public delegate void AddNewNodeEvent(string PCode, string Code, string Name);
        // 接口定义
        public AddNewNodeEvent OnAddNewNodeEvent { get; set; }
        //
        public string NewSortName { get; set; }

        public BAS_存货类别设置_Editor()
        {
            InitializeComponent();
            //
            this.DataBinding_cbx类别状态();
        }

        private void DataBinding_cbx类别状态()
        {
            DataTable dt = null;
            //
            var model = new Ref_WS_STK.DataType_存货_类别();
            model.ExAction = "LBZT";
            AppServer.UsingWcf(() =>
            {
                dt = AppServer.wcfClient.BAS_存货_类别_List(model).Tables[0];
            });  
            //
            this.cbx类别状态.ValueMember = "ID";
            this.cbx类别状态.DisplayMember = "类别状态名称";
            this.cbx类别状态.DataSource = dt;
            //
            this.cbx类别状态.SelectedIndex = 0;
        }

        public void Editor_Add(string PCode, string PName)
        {
            this.Tag = "Add";
            this.Text = "新增存货类别";

            this.txt上级类别名称.Tag = PCode;
            this.txt上级类别名称.Text = PName;
            this.txt类别名称.Focus();
            this.txt类别名称.Tag = "";
        }

        public void Editor_Mod(DataRow dr)
        {
            this.Tag = "Mod";
            this.Text = String.Format("修改存货类别【{0}】", dr["类别名称"]);

            TY.Helper.FormHelper.DataBinding_DataSourceToUI(dr, this);

            this.txt上级类别名称.Tag = dr["上级编码"].ToString();
            this.txt类别名称.Tag = dr["类别编码"].ToString();
            this.txt类别名称.Focus();
            //
            this.btnOK_Add.Visible = false;
        }

        private void btn存货类别_Click(object sender, EventArgs e)
        {
            using (var Fm = new BAS_存货类别设置_Select())
            {
                Fm.Editor_Select(this.txt上级类别名称.Tag.ToString());
                if (Fm.ShowDialog() == DialogResult.OK)
                {
                    this.txt上级类别名称.Tag = Fm.SelectSortCode;
                    this.txt上级类别名称.Text = Fm.SelectSortName;
                }
            }
        }

        private Boolean PostData()
        {
            if (this.txt类别名称.Text == "")
            {
                AppServer.ShowMsg("请输入类别名称");
                this.txt类别名称.Focus();
                return false;
            }
            //
            try
            {
                var model = new Ref_WS_STK.DataType_存货_类别();
                model.ExAction = this.Tag.ToString();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.上级编码 = this.txt上级类别名称.Tag.ToString();
                model.类别编码 = this.txt类别名称.Tag.ToString();
                model.类别状态 = this.cbx类别状态.SelectedValue.ToIntegerDef();
                model.LoginUserCode = AppServer.LoginUserCode;
                AppServer.UsingWcf(() =>
                {
                    AppServer.wcfClient.BAS_存货_类别_Edit(ref model);
                });
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return false;
                }
                //
                this.NewSortName = this.txt类别名称.Text;
                if (this.OnAddNewNodeEvent != null) this.OnAddNewNodeEvent(model.上级编码, model.类别编码, model.类别名称);
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return false;
            }
            return true;
        }

        private void BAS_存货类别设置_Editor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnCancel.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnOk.PerformClick();
            }
        }

        private void btnOK_Add_Click(object sender, EventArgs e)
        {
            if (this.PostData())
            {
                this.txt类别名称.Text = "";
                this.txt类别名称.Focus();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.PostData())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

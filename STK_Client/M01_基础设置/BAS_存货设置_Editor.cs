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
    public partial class BAS_存货设置_Editor : Form
    {
        // 接口声明
        public delegate void AddNewDataEvent(string Value,int index);
        // 接口定义
        public AddNewDataEvent OnAddNewDataEvent { get; set; }
        //
        public BAS_存货设置_Editor()
        {
            InitializeComponent();
            //
            this.DataBinding_cbx计量单位();
            //
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 6, this.btnOK_Add, true);
        }

        private void DataBinding_cbx计量单位()
        {
            var model = new Ref_WS_STK.DataType_存货();
            model.ExAction = "JLDW";
            AppServer.UsingWcf(() =>
            {
                this.cbx计量单位.ValueMember = "ID";
                this.cbx计量单位.DisplayMember = "计量单位";
                this.cbx计量单位.DataSource = AppServer.wcfClient.BAS_存货_List(model).Tables[0];
            });
            //
            this.cbx计量单位.SelectedIndex = -1;
        }

        public void Editor_Add(string PCode, string PName)
        {
            this.Tag = "Add";
            this.Text = "新增存货";
            //
            this.txt类别名称.Text = PName;
            this.txt类别名称.Tag = PCode;
            this.txt存货名称.Focus();
            this.txt存货名称.Tag = "";
        }

        public void Editor_Mod(DataGridViewRow Row)
        {
            this.Text = String.Format("修改存货信息【{0}】", Row.Cells["存货名称"].Value);
            this.Tag = "Mod";
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(Row, this);
            this.txt类别名称.Text = Row.Cells["类别名称"].Value.ToString();
            this.txt类别名称.Tag = Row.Cells["类别编码"].Value.ToString(); ;
            this.txt存货名称.Focus();
            this.txt存货名称.Tag = Row.Cells["存货编码"].Value.ToString();
            this.cbx计量单位.Text = Row.Cells["计量单位"].Value.ToString();
            //
            this.btn存货类别.Enabled = false;
            this.btnOK_Add.Visible = false;
            this.btnEnter.Location = new Point(this.btnEnter.Left - 80, this.btnEnter.Top);
            this.btnCancel.Location = new Point(this.btnCancel.Left + 80, this.btnEnter.Top);
        }

        private void btn存货序号_Click(object sender, EventArgs e)
        {
            using (var Fm = new BAS_存货设置_Select())
            {
                Fm.Select_Mod(this.txt类别名称.Tag.ToString());
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txt存货序号.Text = Fm.CHInfo;
                    this.txt存货序号.Tag = Fm.Index;
                }
            }
        } 

        private void btn存货类别_Click(object sender, EventArgs e)
        {
            using (var Fm = new BAS_存货类别设置_Select())
            {
                Fm.Editor_Select(this.txt类别名称.Tag.ToString());
                if (Fm.ShowDialog() == DialogResult.OK)
                {
                    this.txt类别名称.Tag = Fm.SelectSortCode;
                    this.txt类别名称.Text = Fm.SelectSortName;
                }
            }
        }

        private bool PostData()
        {
            if (String.IsNullOrWhiteSpace(this.txt存货名称.Text))
            {
                AppServer.ShowMsg("存货名称不能为空或是全部空格");
                return false;
            }
            if (this.rdbtn自定义.Checked && String.IsNullOrEmpty(this.txt存货序号.Text))
            {
                AppServer.ShowMsg("您选择的插入顺序为自定义，但没有选择存货");
                return false;
            }
            //
            var model = new Ref_WS_STK.DataType_存货();
            model.ExAction = this.Tag.ToString();
            model.存货编码 = this.txt存货名称.Tag.ToString();
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
            model.类别编码 = this.txt类别名称.Tag.ToString();
            model.计量单位 = this.cbx计量单位.Text;
            model.LoginUserCode = AppServer.LoginUserCode;
            model.上一个序号 = this.rdbtn自定义.Checked ? this.txt存货序号.Tag.ToIntegerDef() : -1;
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.BAS_存货_Edit(ref model);
            });
            //
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_Error(model.ErrorMsg);
                return false;
            }
            if (this.OnAddNewDataEvent != null) this.OnAddNewDataEvent(this.txt类别名称.Tag.ToString(), model.类别序号);
            return true;
        }

        private void BAS_存货设置_Editor_KeyUp(object sender, KeyEventArgs e)
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

        private void btnOK_Add_Click(object sender, EventArgs e)
        {
            if (PostData())
            {
                this.txt规格型号.Text = "";
                this.txt规格型号.Focus();
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

        private void rdbtn自定义_CheckedChanged(object sender, EventArgs e)
        {
            this.lbl自定义.Visible = (sender as RadioButton).Checked;
            this.txt存货序号.Visible = (sender as RadioButton).Checked;
            this.btn存货序号.Visible = (sender as RadioButton).Checked;
        }
     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace STK_Client.M03_期末管理
{
    public partial class STK_期末结账 : Form
    {
        public STK_期末结账()
        {
            InitializeComponent();
            //
            this.lblTitle.Text = String.Format("期末会计期间列表({0})", this.dtp年份.Value.Year);
            this.dbGridView.GridStr(AppServer.GetTableDef("STK_期末结账"));
            AppServer.SetGridViewStyle(this.dbGridView);
            //
            this.DataBinding_cbx仓库编码();
            //
            //this.btn查询.PerformClick();
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

        private void cbx仓库编码_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(0);
        }

        private void dtp年份_ValueChanged(object sender, EventArgs e)
        {
            this.lblTitle.Text = String.Format("期末会计期间列表({0})", this.dtp年份.Value.Year);
            //
            this.DataBinding_dbGridView(0);
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(0);
        }

        private void DataBinding_dbGridView(int ARowIndex)
        {
            var model = new Ref_WS_STK.DataType_会计期间();
            model.ExAction = "List";
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            model.年份 = this.dtp年份.Value.Year.ToString();
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_会计期间_List(model).Tables[0];
            });
            //
            this.dbGridView.GoToRowByIndex(ARowIndex);
        }
        private void btn结账_Click(object sender, EventArgs e)
        {
            string Period = "";
            DataView dv = new DataView(this.dbGridView.DataSource as DataTable);
            dv.RowFilter = "结账标志 = 0";
            if (dv.Count == 0)
            {
                AppServer.ShowMsg("对不起，没有找到未结账的会计期间");
                return;
            }
            else
            {
                Period = dv[0]["会计期间"].ToString();
            }
            //
            using (var Fm = new M03_期末管理.STK_期末结账_Select())
            {
                Fm.SetValue(Period);
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    //
                    var model = new Ref_WS_STK.DataType_会计期间();
                    model.ExAction = "JZ";  //结账
                    model.仓库编码 = Fm.PCKCode;
                    model.会计期间 = Period;
                    AppServer.UsingWcf(() =>
                    {
                        AppServer.wcfClient.BAS_会计期间_Edit(ref model);
                    });
                    //
                    this.Cursor = Cursors.Default;
                    //
                    if (model.ExResult != 0)
                    {
                        AppServer.ShowMsg_Error(model.ErrorMsg);
                    }
                    else
                    {
                        AppServer.ShowMsg(String.Format("{0}的账单已结账", Period));
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

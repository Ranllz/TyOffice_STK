using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace STK_Client.M04_库存报表
{
    public partial class STK_库存总账_明细 : Form
    {
        public STK_库存总账_明细()
        {
            InitializeComponent();          
        }

        public void View_RK(string CKCode, string CKName, string CHCode, string CHName, string GGXH, string KJQJ)
        {
            this.Text = String.Format("查看入库信息一{0}", CHName);
            this.lblTitle.Text = "入库信息列表";
            this.lbl仓库名称.Text = String.Format("查看仓库：{0}", CKName);
            this.lbl存货名称.Text = String.Format("查看存货：{0}  {1}", CHName, GGXH);
            this.lbl会计期间.Text = String.Format("会计期间：{0}", KJQJ);
            //
            AppServer.SetGridViewStyle(this.dbGridView);
            this.dbGridView.GridStr(AppServer.GetTableDef("STK_库存总账_入库明细"));
            //
            var model = new Ref_WS_STK.DataType_库存管理();
            model.ExAction = "RK_Dtl";
            model.仓库编码 = CKCode;
            model.存货编码 = CHCode;
            model.会计期间 = KJQJ;
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.STK_库存总账_List(model).Tables[0];
            });
        }

        public void View_CK(string CKCode, string CKName, string CHCode, string CHName, string GGXH, string KJQJ)
        {
            this.Text = String.Format("查看出库信息一{0}", CHName);
            this.lblTitle.Text = "出库信息列表";
            this.lbl仓库名称.Text = String.Format("查看仓库：{0}", CKName);
            this.lbl存货名称.Text = String.Format("查看存货：{0}  {1}", CHName, GGXH);
            this.lbl会计期间.Text = String.Format("会计期间：{0}", KJQJ);
            //
            AppServer.SetGridViewStyle(this.dbGridView);
            this.dbGridView.GridStr(AppServer.GetTableDef("STK_库存总账_出库明细"));
            //
             var model = new Ref_WS_STK.DataType_库存管理();
             model.ExAction = "CK_Dtl";
            model.仓库编码 = CKCode;
            model.存货编码 = CHCode;
            model.会计期间 = KJQJ;
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.STK_库存总账_List(model).Tables[0];
            });
        }

        private void STK_账单管理_出入库_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnCancel.PerformClick();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

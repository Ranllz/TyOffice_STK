using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using TY.Controls;
using TY.Grids;

namespace STK_Client.M04_库存报表
{
    public partial class STK_库存总账 : Form
    {
        public STK_库存总账()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("STK_库存总账"));
            AppServer.SetGridViewStyle(this.dbGridView);
            this.dbGridView.Columns["计量单位"].Frozen = true;
            //
            this.DataBinding_dbTreeView();
            this.DataBinding_cbx仓库编码();            
        }

        private void DataBinding_dbTreeView()
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                var model = new Ref_WS_STK.DataType_存货_类别();
                model.ExAction = "Tree";
                model.类别状态 = 0;
                AppServer.UsingWcf(() =>
                {
                    this.dbTreeView.DataSource = AppServer.wcfClient.BAS_存货_类别_List(model).Tables[0];
                });
                //
                this.dbTreeView.ClearTrees();
                this.dbTreeView.NodeID = "类别编码";
                this.dbTreeView.NodePID = "上级编码";
                this.dbTreeView.NodeTitle = "类别名称";
                this.dbTreeView.BuildTrees();
                //this.dbTreeView.Nodes[0].Expand();
                //this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                DBTreeNode PNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                while (PNode.FirstNode != null)
                {
                    PNode = (DBTreeNode)PNode.FirstNode;
                }
                //
                this.dbTreeView.SelectedNode = PNode;
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
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
        }

        private void DataBinding_cbx会计期间()
        {
            var model = new Ref_WS_STK.DataType_会计期间();
            model.ExAction = "AllFinish";
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            AppServer.UsingWcf(() =>
            {
                this.cbx会计期间.ValueMember = "会计期间";
                this.cbx会计期间.DisplayMember = "会计期间";
                this.cbx会计期间.DataSource = AppServer.wcfClient.BAS_会计期间_List(model).Tables[0];
            });
            //
            if (this.cbx会计期间.Items.Count > 0)
            {
                this.cbx会计期间.SelectedIndex = 0;
            }
        }

        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.DataBinding_dbGridView(((DBTreeNode)e.Node).ID, 0);
        }

        public void DataBinding_dbGridView(string ASortCode, int ARowIndex)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_库存管理();
            model.ExAction = "List";
            model.类别编码 = ASortCode;
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            model.会计期间 = this.cbx会计期间.Text;
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.STK_库存总账_List(model).Tables[0];
            });
            this.dbGridView.GoToRowByIndex(ARowIndex);
            //        
            base.Cursor = Cursors.Default;
        }

        private void cbx仓库编码_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_cbx会计期间();
            this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
            //
            this.btn下一期间.Enabled = this.cbx会计期间.SelectedIndex > 0;
            this.btn上一期间.Enabled = this.cbx会计期间.SelectedIndex + 1 < this.cbx会计期间.Items.Count;

        }

        private void txt存货名称_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn查询.PerformClick();
                this.txt存货名称.Focus();
            }
        }

        private void cbx会计期间_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_库存管理();
            model.ExAction = "List";
            model.类别编码 = this.dbTreeView.SelectedNode.ID;
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            model.会计期间 = this.cbx会计期间.Text;
            model.存货名称 = this.txt存货名称.Text.Trim();
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.STK_库存总账_List(model).Tables[0];
            });
            this.dbGridView.GoToRowByIndex(0);
            //        
            base.Cursor = Cursors.Default;
        }

        private void btn结账_Click(object sender, EventArgs e)
        {
            using (var Fm = new M03_期末管理.STK_期末结账_Select())
            {
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    //
                    var model = new Ref_WS_STK.DataType_会计期间();
                    model.ExAction = "JZ";  //结账
                    model.仓库编码 = Fm.PCKCode;
                    AppServer.UsingWcf(() =>
                    {
                     //   AppServer.wcfClient.STK_期末结账_Edit(ref model);
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
                        AppServer.ShowMsg("结账完成");
                        //
                        this.DataBinding_cbx会计期间();
                    }
                }
            }
        }

        private void btn下一期间_Click(object sender, EventArgs e)
        {          
            int index = -1;
            index = this.cbx会计期间.SelectedIndex - 1;
            if (index > -1)
            {
                this.cbx会计期间.SelectedIndex = index;
            }
        }

        private void btn上一期间_Click(object sender, EventArgs e)
        {
            int index = -1;
            index = this.cbx会计期间.SelectedIndex + 1;
            if (index + 1 <= this.cbx会计期间.Items.Count)
            {
                this.cbx会计期间.SelectedIndex = index;
            }
        }

        private void btn入库_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //
            using (var Fm = new STK_库存总账_明细())
            {
                Fm.View_RK((string)this.cbx仓库编码.SelectedValue, this.cbx仓库编码.Text
                    , this.dbGridView.SelectedRows[0].Cells["存货编码"].Value.ToString()
                    , this.dbGridView.SelectedRows[0].Cells["存货名称"].Value.ToString()
                    , this.dbGridView.SelectedRows[0].Cells["规格型号"].Value.ToString()
                    , this.cbx会计期间.Text
                    );
                Fm.ShowDialog();
            }
        }

        private void btn出库_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //
            using (var Fm = new STK_库存总账_明细())
            {
                Fm.View_CK((string)this.cbx仓库编码.SelectedValue, this.cbx仓库编码.Text
                    , this.dbGridView.SelectedRows[0].Cells["存货编码"].Value.ToString()
                    , this.dbGridView.SelectedRows[0].Cells["存货名称"].Value.ToString()
                     , this.dbGridView.SelectedRows[0].Cells["规格型号"].Value.ToString()
                    , this.cbx会计期间.Text
                    );
                Fm.ShowDialog();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string KJQJ = "";
            using (var Fm = new M03_期末管理.STK_期末结账_Select())
            {
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var model = new Ref_WS_STK.DataType_会计期间();
                    model.ExAction = "New";
                    model.仓库编码 = Fm.PCKCode;
                    AppServer.UsingWcf(() =>
                    {
                        AppServer.wcfClient.BAS_会计期间_Edit(ref model);
                    });
                    //
                    if (model.ExResult != 0)
                    {
                        AppServer.ShowMsg(model.ErrorMsg);
                        return;
                    }
                    else
                    {
                        AppServer.ShowMsg(String.Format("会计期间创建成功   {0}", model.会计期间));
                        this.DataBinding_cbx会计期间();
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.dbGridView.Preview("存货账单列表", "A4", true, String.Format("单位：长葛市恒光热电有限责任公司  仓库名称：{0}  会计期间：{1}",this.cbx仓库编码.Text,this.cbx会计期间.Text), "生成日期:" + DateTime.Now.ToString(), "", "@页码");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

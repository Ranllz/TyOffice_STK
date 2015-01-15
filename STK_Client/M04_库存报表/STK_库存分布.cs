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
    public partial class STK_库存分布 : Form
    {
        public STK_库存分布()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("STK_库存分布"));
            AppServer.SetGridViewStyle(this.dbGridView);
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


        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_库存分布();
            model.ExAction = "List";
            model.类别编码 = this.dbTreeView.SelectedNode.ID;
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.STK_库存分布_List(model).Tables[0];
            });
            this.dbGridView.GoToRowByIndex(0);
            //        
            base.Cursor = Cursors.Default;
        }

        private void cbx仓库编码_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn刷新.PerformClick();
        }

        private void txt存货名称_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn刷新.PerformClick();
                this.txt存货名称.Focus();
            }
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_库存分布();
            model.ExAction = "List";
            model.类别编码 = this.dbTreeView.SelectedNode.ID;
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            model.存货名称 = this.txt存货名称.Text.Trim();
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.STK_库存分布_List(model).Tables[0];
            });
            this.dbGridView.GoToRowByIndex(0);
            //        
            base.Cursor = Cursors.Default;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.dbGridView.Preview("存货信息列表", "A4", true, String.Format("单位：长葛市恒光热电有限责任公司  仓库名称：{0} ", this.cbx仓库编码.Text), "生成日期:" + DateTime.Now.ToString(), "", "@页码");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

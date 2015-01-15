using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Controls;
using TY.Helper;

namespace STK_Client.M01_基础设置
{
    public partial class BAS_存货类别设置_Select : Form
    {
        public string SelectSortCode { get; set; }
        public string SelectSortName { get; set; }
        
        public BAS_存货类别设置_Select()
        {
            InitializeComponent();
            //
            this.DataBinding_dbTreeView();
        }

        public void Editor_Select(string code)
        {
            DBTreeNode node = this.dbTreeView.FindTreeNode(code);
            if (node != null)
            {
                this.dbTreeView.SelectedNode = node;
            }
        }

        private void DataBinding_dbTreeView()
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                var model = new Ref_WS_STK.DataType_存货_类别();
                model.ExAction = "Tree";
                model.类别状态 = 1;
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
                this.dbTreeView.Nodes[0].Expand();
                this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                base.Cursor = Cursors.Arrow;
            }
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.btnSelect.PerformClick();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.dbTreeView.SelectedNode.GetNodeCount(false) != 0) return;
            //
            if (this.dbTreeView.SelectedNode == null) return;
            //
            this.SelectSortCode = this.dbTreeView.SelectedNode.ID;
            this.SelectSortName = this.dbTreeView.SelectedNode.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

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
    public partial class BAS_货架设置_Select : Form
    {
        public string CKCode = "";
        public string CKName = "";
        //
        public BAS_货架设置_Select()
        {
            InitializeComponent();
            //
            this.Text = String.Format("选择存放货架");
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_货架设置_Select"));
            //
            this.DataBinding_dbTreeView();
        }

        private void DataBinding_dbTreeView()
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                var model = new Ref_WS_STK.DataType_仓库();
                model.ExAction = "Tree";
                model.上级编码 = this.CKCode;
                AppServer.UsingWcf(() =>
                {
                    this.dbTreeView.DataSource = AppServer.wcfClient.BAS_仓库_List(model).Tables[0];
                });
                //
                this.dbTreeView.ClearTrees();
                this.dbTreeView.NodeID = "仓库编码";
                this.dbTreeView.NodePID = "上级编码";
                this.dbTreeView.NodeTitle = "仓库名称";
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

        public void Select_Mod(string Code)
        {
            this.CKCode = Code;
        }

        private void BAS_货架设置_Select_Load(object sender, EventArgs e)
        {
            this.DataBinding_dbTreeView();
        } 

        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "List";
            model.上级编码 = (e.Node as DBTreeNode).ID;         
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_货架_List(model).Tables[0];
            });
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.btnSelect.PerformClick();
        }

        private void dbGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.btnSelect.PerformClick();
            }
        }

        private void BAS_货架设置_Select_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnSelect.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.btnClose.PerformClick();
            }
        }  

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //
            this.CKCode = this.dbGridView.CurrentRow.Cells["货架编码"].Value.ToString();
            this.CKName = this.dbGridView.CurrentRow.Cells["货架名称"].Value.ToString();
            if (!String.IsNullOrEmpty(this.dbGridView.CurrentRow.Cells["货架位置"].Value.ToString()))
            {
                this.CKName = String.Format("{0}（{1}）", this.CKName,
                    this.dbGridView.CurrentRow.Cells["货架位置"].Value);
            }
            //
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        } 
    }
}

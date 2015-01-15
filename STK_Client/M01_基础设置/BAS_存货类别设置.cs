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
    public partial class BAS_存货类别设置 : Form
    {
        public BAS_存货类别设置()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_存货类别设置"));
            AppServer.SetGridViewStyle(this.dbGridView);
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
            DataRow row = dt.NewRow();
            row["ID"] = 0;
            row["类别状态名称"] = "所有的";
            dt.Rows.Add(row);
            //
            DataView dv = new DataView(dt);
            dv.Sort = "ID ASC";
            //
            this.cbx类别状态.ValueMember = "ID";
            this.cbx类别状态.DisplayMember = "类别状态名称";
            this.cbx类别状态.DataSource = dv;
            //
            this.cbx类别状态.SelectedIndex = 1;
        }

        private void cbx类别状态_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_dbTreeView();
        }

        private void DataBinding_dbTreeView()
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                var model = new Ref_WS_STK.DataType_存货_类别();
                model.ExAction = "Tree";
                model.类别状态 = this.cbx类别状态.SelectedValue.ToIntegerDef();
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

        public void AddNewNodeEvent(string PCode, string Code, string Name)
        {
            this.dbTreeView.SelectedNode.Expand();
            DBTreeNode node = new DBTreeNode();
            node.PID = PCode;
            node.ID = Code;
            node.Text = Name;
            node.ImageIndex = 1;
            this.dbTreeView.SelectedNode.Nodes.Add(node);
            if (!this.dbTreeView.SelectedNode.IsExpanded) this.dbTreeView.ExpandAll();
            //
            this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
        }

        private void DataBinding_dbGridView(string ASortCode, int ARowIndex)
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                var model = new Ref_WS_STK.DataType_存货_类别();
                model.上级编码 = ASortCode;
                model.类别状态 = this.cbx类别状态.SelectedValue.ToIntegerDef();
                model.PageRows = 0;
                AppServer.UsingWcf(() =>
                {
                    this.dbGridView.DataSource = AppServer.wcfClient.BAS_存货_类别_List(model).Tables[0];
                });
                this.dbGridView.GoToRowByIndex(ARowIndex);
            }
            catch (Exception exp)
            {
                AppServer.ShowMsg_Error(exp.Message);
            }
            finally
            {
                base.Cursor = Cursors.Arrow;
            }
        }

        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.DataBinding_dbGridView(((DBTreeNode)e.Node).ID, 0);
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.btnMod.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var Fm = new BAS_存货类别设置_Editor())
            {
                Fm.Editor_Add(this.dbTreeView.SelectedNode.ID, this.dbTreeView.SelectedNode.Text);
                Fm.OnAddNewNodeEvent = this.AddNewNodeEvent;
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (this.dbTreeView.SelectedNode == null) return;
            if (this.dbTreeView.SelectedNode.Level == 0) return;
            //
            using (var form = new BAS_存货类别设置_Editor())
            {
                DataRow row = (this.dbGridView.DataSource as DataTable).Locate("类别编码", this.dbTreeView.SelectedNode.ID);
                if (row == null)
                {
                    AppServer.ShowMsg_Error("没有找到当前类别的数据啊，为什么呢？");
                    return;
                }
                //
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.dbTreeView.SelectedNode.Text = form.NewSortName;
                    //
                    this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dbTreeView.SelectedNode.Parent == null) return;
            if (this.dbTreeView.SelectedNode.Level == 0) return;
            if (this.dbTreeView.SelectedNode.Nodes.Count > 0)
            {
                AppServer.ShowMsg("请先删除当前类别下的子类别后再删除当前类别!");
                return;
            }
            if (!AppServer.DialogMsg("确认要删除当前类别吗?")) return;
            //
            var model = new Ref_WS_STK.DataType_存货_类别();
            model.ExAction = "Del";
            model.类别编码 = this.dbTreeView.SelectedNode.ID;
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.BAS_存货_类别_Edit(ref model);
            });
            //
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                return;
            }
            DBTreeNode pnode = (DBTreeNode)this.dbTreeView.SelectedNode.Parent;
            this.dbTreeView.SelectedNode.Remove();
            this.dbTreeView.SelectedNode = pnode;
        }

        private void btn修改状态_Click(object sender, EventArgs e)
        {
            if (this.dbTreeView.SelectedNode.Parent == null) return;
            if (this.dbTreeView.SelectedNode.Level == 0) return;
            //
            using (var form = new BAS_存货类别设置_修改状态())
            {
                DataRow row = (this.dbGridView.DataSource as DataTable).Locate("类别编码", this.dbTreeView.SelectedNode.ID);
                if (row == null)
                {
                    AppServer.ShowMsg_Error("没有找到当前类别的数据啊，为什么呢？");
                    return;
                }
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

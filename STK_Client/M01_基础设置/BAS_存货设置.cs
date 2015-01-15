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

namespace STK_Client.M01_基础设置
{
    public partial class BAS_存货设置 : Form
    {
        public BAS_存货设置()
        {
            InitializeComponent();
            //
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_存货设置"));
            AppServer.SetGridViewStyle(this.dbGridView);
            //
            this.DataBinding_dbTreeView();
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
            this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
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

        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.DataBinding_dbGridView(((DBTreeNode)e.Node).ID, 0);
        }

        public void DataBinding_dbGridView(string ASortCode, int ARowIndex)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_存货();
            model.类别编码 = ASortCode;
            model.存货状态 = this.cbx类别状态.SelectedValue.ToIntegerDef();
            AppServer.UsingWcf(()=>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_存货_List(model).Tables[0];
            });
            this.lbl物资.Text = String.Format("共有 {0} 条记录", this.dbGridView.Rows.Count);
            //   
            this.dbGridView.GoToRowByIndex(ARowIndex);         
            //        
            base.Cursor = Cursors.Arrow;          
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (this.dbTreeView.SelectedNode.GetNodeCount(false) == 0)
            {
                this.btnAdd.PerformClick();
            }
        }

        private void dbGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnMod.PerformClick();
        }

        private void AddNewDataEvent(string Value,int ANewRowIndex)
        {
            DBTreeNode Node = null;
            foreach(DBTreeNode pnode in this.dbTreeView.Nodes)
            {
                Node = FindTreeNode(Value, pnode);
                if(Node != null)
                {
                    this.dbTreeView.SelectedNode = Node;
                    break;
                }
            }
            this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, ANewRowIndex-1);            
            dbGridView.FirstDisplayedScrollingRowIndex = dbGridView.Rows[ANewRowIndex - 1].Index;
        }

        private DBTreeNode FindTreeNode(string value, DBTreeNode PNode)
        {
            if (PNode == null)
                return null;
            if (PNode.ID.Equals(value))
                return PNode;
            DBTreeNode tnRet = null;
            foreach (DBTreeNode tn in PNode.Nodes)
            {
                tnRet = FindTreeNode(value, tn);
                if (tnRet != null)
                    break;
            }
            return tnRet;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.dbTreeView.SelectedNode == null) return;
            //
            DataTable table = this.dbTreeView.DataSource as DataTable;
            DataRow row = table.Locate("类别编码", this.dbTreeView.SelectedNode.ID);
            if (row == null) return;
            //
            using (var form = new BAS_存货设置_Editor())
            {
                form.OnAddNewDataEvent = AddNewDataEvent;
                form.Editor_Add(this.dbTreeView.SelectedNode.ID, this.dbTreeView.SelectedNode.Text);
                if (form.ShowDialog() == DialogResult.OK)
                {
                 //   this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //
            using (var fm = new BAS_存货设置_Editor())
            {
                fm.Editor_Mod(this.dbGridView.SelectedRows[0]);
                if (fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, this.dbGridView.CurrentRow.Index);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.Rows.Count == 0) return;
            if (!AppServer.DialogMsg("确定要删除该存货")) return;
            //
            var model = new Ref_WS_STK.DataType_存货();
            model.ExAction = "Del";
            foreach (DataGridViewRow Row in this.dbGridView.SelectedRows)
            {
                model.存货编码 = Row.Cells["存货编码"].Value.ToString();
                AppServer.UsingWcf(() =>
                {
                    AppServer.wcfClient.BAS_存货_Edit(ref model);
                });
            }
            //
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_Error(model.ErrorMsg);
            }
            else
            {
                this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn修改状态_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //
            using (var Fm = new BAS_存货设置_修改状态())
            {
                Fm.Editor_Mod(this.dbGridView.SelectedRows[0]);
                if (Fm.ShowDialog() == DialogResult.OK)
                {
                    var model = new Ref_WS_STK.DataType_存货();
                    model.ExAction = "Mod_ZT";
                    foreach (DataGridViewRow Row in this.dbGridView.SelectedRows)
                    {
                        model.存货编码 = Row.Cells["存货编码"].Value.ToString();
                        model.存货状态 = Fm.Value;
                        AppServer.UsingWcf(() =>
                        {
                            AppServer.wcfClient.BAS_存货_Edit(ref model);
                        });
                        //
                        if (model.ExResult != 0)
                        {
                            AppServer.ShowMsg_Error(model.ErrorMsg);
                            break;
                        }
                    }
                    //
                    this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
                }
            }
        }

        private void btn设置存放仓库_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.SelectedRows.Count == 0) return;
            //
            using (var Fm = new BAS_存货设置_选择仓库())
            {
                Fm.Editor_Mod(this.dbGridView.SelectedRows[0].Cells["默认仓库编码"].Value.ToString());
                if (Fm.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    //
                    var model = new Ref_WS_STK.DataType_存货();
                    model.ExAction = "Bind_MRCK";
                    AppServer.UsingWcf(() =>
                    {
                        foreach (DataGridViewRow Row in this.dbGridView.SelectedRows)
                        {
                            model.存货编码 = Row.Cells["存货编码"].Value.ToString();
                            model.默认仓库编码 = Fm.CKCodes;                      
                            AppServer.wcfClient.BAS_存货_Edit(ref model);
                            //
                            if (model.ExResult != 0)
                            {
                                AppServer.ShowMsg_Error(model.ErrorMsg);
                                break;
                            }
                            //
                            Row.Cells["默认仓库"].Value = Fm.CKNames;
                            Row.Cells["默认仓库编码"].Value = Fm.CKCodes;
                        }
                    });   
                    //
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.dbGridView.Preview("库存信息列表", "A4", true, String.Format("单位：长葛市恒光热电有限责任公司  存货类别：{0} ", this.dbTreeView.SelectedNode.Text), "生成日期:" + DateTime.Now.ToString(), "", "@页码");
        }
    }
}

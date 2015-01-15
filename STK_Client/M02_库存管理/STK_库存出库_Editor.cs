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

namespace STK_Client.M02_库存管理
{
    public partial class STK_库存出库_Editor : Form
    {
        public STK_库存出库_Editor()
        {
            InitializeComponent();
            //
            this.dbGridView_CH.GridStr(AppServer.GetTableDef("STK_库存出库_CH"));
            AppServer.SetGridViewStyle(this.dbGridView_CH);
            //
            AppServer.SetGridViewStyle(this.dbGridView_CK);
            this.dbGridView_CK.GridStr(AppServer.GetTableDef("STK_库存出库_CK"));
            this.dbGridView_CK.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            //       
            this.DataBinding_dbTreeView();
            this.DataBinding_cbx供应商编码();
            this.DataBinding_cbx仓库编码();
            //
            this.dtp业务日期.Value = AppServer.LoginWorkDate;
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
            base.Cursor = Cursors.WaitCursor;
            //
            try
            {
                var model = new Ref_WS_STK.DataType_存货();
                model.ExAction = "CK_List";
                model.类别编码 = ((DBTreeNode)e.Node).ID;
                model.默认仓库编码 = (string)this.cbx仓库编码.SelectedValue;
                model.可出库 = this.chk可出库.Checked;
                AppServer.UsingWcf(() =>
                {
                    this.dbGridView_CH.DataSource = AppServer.wcfClient.BAS_存货_List(model).Tables[0];
                });
                this.dbGridView_CH.GoToRowByIndex(0);
            }
            catch(Exception exp)
            {
                AppServer.ShowMsg_Error(exp.Message);
            }
            //        
            base.Cursor = Cursors.Arrow;
            //
            this.txt存货名称.Focus();
        }

        public void DataBinding_dbGridView_WL(string ASortCode, int ARowIndex)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            try
            {
                var model = new Ref_WS_STK.DataType_存货();
                model.ExAction = "CK_List";
                model.类别编码 = ASortCode;
                model.存货名称 = this.txt存货名称.Text.Trim();
                model.默认仓库编码 = (string)this.cbx仓库编码.SelectedValue;
                model.可出库 = this.chk可出库.Checked;
                AppServer.UsingWcf(() =>
                {
                    this.dbGridView_CH.DataSource = AppServer.wcfClient.BAS_存货_List(model).Tables[0];
                });
                this.dbGridView_CH.GoToRowByIndex(ARowIndex);
            }
            catch
            { }
            //        
            base.Cursor = Cursors.Arrow;
            //
            this.txt存货名称.Focus();
        }

        private void DataBinding_cbx供应商编码()
        {
            var model = new Ref_WS_STK.DataType_供应商();
            model.ExAction = "AllDW";
            AppServer.UsingWcf(() =>
            {
                this.cbx供应商编码.ValueMember = "供应商编码";
                this.cbx供应商编码.DisplayMember = "供应商名称";
                this.cbx供应商编码.DataSource = AppServer.wcfClient.BAS_供应商_List(model).Tables[0];
            });
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
            if (this.cbx仓库编码.Items.Count == 0)
            { 
            
            }
        }


        public void Editor_Add()
        {
            this.Text = "新建出库单";
            this.Tag = "";
            this.btnEnter.Tag = "Add";
            this.txt制单人.Text = AppServer.LoginUserName;
            //
            string CKCode = Properties.Settings.Default.CKCode;
            int index = 0;
            //
            foreach (DataRowView item in this.cbx仓库编码.Items)
            {
                if (CKCode.Equals(item["仓库编码"].ToString())) break;
                index++;
            }
            //
            if (index >= this.cbx仓库编码.Items.Count)
            {
                this.cbx仓库编码.SelectedIndex = 0;
            }
            else
            {
                this.cbx仓库编码.SelectedIndex = index;
            }
        }

        public void Editor_Mod(String CKCode)
        {
            this.Text = String.Format("修改出库单---{0}", CKCode);
            this.Tag = CKCode;
            this.btnEnter.Tag = "Mod";
            //
            DataSet ds = null;
            var model = new Ref_WS_STK.DataType_库存管理();
            model.单据编码 = CKCode;
            AppServer.UsingWcf(() =>
            {
                ds = AppServer.wcfClient.STK_库存出库_List(model);
            });
            //
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                TY.Helper.FormHelper.DataBinding_DataSourceToUI(ds.Tables[0].Rows[0], this);
            }
            if (ds.Tables.Count > 1)
            {
                this.dbGridView_CK.DataSource = ds.Tables[1];
            }
        }

        public void Editor_See(String RKCode)
        {
            this.Text = String.Format("查看出库单---{0}", RKCode);
            this.lblTitle.Text = "出 库 单";
            //
            this.cbx供应商编码.DataSource = null;
            this.cbx供应商编码.Items.Clear();
            this.cbx仓库编码.DataSource = null;
            this.cbx仓库编码.Items.Clear();
            this.dtp业务日期.Enabled = false;
            this.txt原始单号.Enabled = false;
            this.txt备注.Enabled = false;
            //
            this.sltContainer.SplitterDistance = 0;
            this.sltContainer.SplitterWidth = 1;
            this.pnlTool.Visible = false;
            //
            this.btnCancel.Size = new System.Drawing.Size(this.btnEnter.Right - this.btnCancel.Left, 28);
            this.btnCancel.Text = "返回(&X)";
            this.btnEnter.Visible = false;
            //
            DataSet ds = null;
            var model = new Ref_WS_STK.DataType_库存管理();
            model.单据编码 = RKCode;
            AppServer.UsingWcf(() =>
            {
                ds = AppServer.wcfClient.STK_库存出库_List(model);
            });
            //
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                TY.Helper.FormHelper.DataBinding_DataSourceToUI(ds.Tables[0].Rows[0],
 this);
                this.cbx供应商编码.Items.Add(ds.Tables[0].Rows[0]["供应商名称"].ToString());
                this.cbx仓库编码.Items.Add(ds.Tables[0].Rows[0]["仓库名称"].ToString());
                this.cbx供应商编码.SelectedIndex = 0;
                this.cbx仓库编码.SelectedIndex = 0;
            }
            if (ds.Tables.Count > 1)
            {
                this.dbGridView_CK.DataSource = ds.Tables[1];
            }
        }

        private void cbx仓库编码_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView_WL(this.dbTreeView.SelectedNode.ID, 0);
        }

        private void txt存货名称_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DataBinding_dbGridView_WL(this.dbTreeView.SelectedNode.ID, 0);
            }
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            try
            {
                var model = new Ref_WS_STK.DataType_存货();
                model.ExAction = "CK_List";
                model.类别编码 = this.dbTreeView.SelectedNode.ID;
                model.存货名称 = this.txt存货名称.Text.Trim();
                model.默认仓库编码 = (string)this.cbx仓库编码.SelectedValue;
                model.可出库 = this.chk可出库.Checked;
                AppServer.UsingWcf(() =>
                {
                    this.dbGridView_CH.DataSource = AppServer.wcfClient.BAS_存货_List(model).Tables[0];
                });
            }
            catch(Exception exp)
            {
                AppServer.ShowMsg_Error(exp.Message);
            }
            //        
            base.Cursor = Cursors.Arrow;
            //
            this.txt存货名称.Focus();
        }

        private void btn添加_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dbGridView_CH.SelectedRows)
            {
                if (row.Cells["存货数量"].Value.ToDecimalDef() <= 0)
                {
                    AppServer.ShowMsg_Warn(String.Format("对不起，“{0}【{1}】”当前库存为{2:N2}，不能再出库了", 
                            row.Cells["存货名称"].Value, 
                            row.Cells["规格型号"].Value,
                            row.Cells["存货数量"].Value));
                    return;
                }
            }
            //
            DataTable tt = this.dbGridView_CK.DataSource as DataTable;
            if (tt == null)
            {
                tt = new DataTable();
                tt.ColumnEx("存货编码/存货名称/规格型号/计量单位:string,存货数量/出库单价/出库数量/出库金额:decimal,存放货架/货架编码:string");
            }
            //
            DataView Dv = new DataView(this.dbGridView_CK.DataSource as DataTable);
            //
            foreach (DataGridViewRow row in this.dbGridView_CH.SelectedRows)
            {
                Dv.RowFilter = String.Format("存货编码='{0}'", row.Cells["存货编码"].Value);
                if (Dv.Count > 0)
                {
                    foreach (DataGridViewRow item in this.dbGridView_CK.Rows)
                    {
                        if (item.Cells["存货编码"].Value.ToString().Equals(row.Cells["存货编码"].Value.ToString()))
                        {
                            item.Cells["出库数量"].Value = item.Cells["出库数量"].Value.ToDecimalDef() + 1;
                            break;
                        }
                    }
                }
                else
                {
                    tt.Rows.Add(
                            row.Cells["存货编码"].Value.ToString(),
                            row.Cells["存货名称"].Value.ToString(),
                            row.Cells["规格型号"].Value.ToString(),
                            row.Cells["计量单位"].Value.ToString(),
                            row.Cells["存货数量"].Value.ToDecimalDef(),
                            row.Cells["出库单价"].Value.ToDecimalDef(),
                            0,
                            0,
                            row.Cells["存放货架"].Value.ToString(),
                            row.Cells["货架编码"].Value.ToString()
                        );
                }
            }
            this.dbGridView_CK.DataSource = tt;
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            List<int> ls = new List<int>();
            if (this.dbGridView_CK.DataSource != null && this.dbGridView_CK.Rows.Count > 0 && this.dbGridView_CK.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in this.dbGridView_CK.SelectedCells)
                {
                    if (ls.Find(s => s == cell.RowIndex) == 0)
                    {
                        this.dbGridView_CK.Rows.Remove(this.dbGridView_CK.Rows[cell.RowIndex]);
                        ls.Add(cell.RowIndex);
                    }
                }
                (this.dbGridView_CK.DataSource as DataTable).AcceptChanges();
            }
        }

        private void btn清空_Click(object sender, EventArgs e)
        {
            if (this.dbGridView_CK.DataSource != null)
            {
                (this.dbGridView_CK.DataSource as DataTable).Rows.Clear();
            }
        }

        private void btnSetCnt_Click(object sender, EventArgs e)
        {
            if (this.dbGridView_CK.Rows.Count == 0 || this.dbGridView_CK.SelectedCells.Count == 0) return;
            //
            //
            bool fg = false;
            foreach (DataGridViewCell Cell in this.dbGridView_CK.SelectedCells)
            {
                if (this.dbGridView_CK.Columns[Cell.ColumnIndex].HeaderText.Equals("出库单价")
                    || this.dbGridView_CK.Columns[Cell.ColumnIndex].HeaderText.Equals("出库数量")
                    || this.dbGridView_CK.Columns[Cell.ColumnIndex].HeaderText.Equals("金额"))
                {
                    fg = true;
                    break;
                }
            }
            if (!fg)
            {
                AppServer.ShowMsg_Warn("所选内容没有包含入库单价、入库数量和金额，请核对");
                return;
            }
            //            
            using (var Fm = new STK_库存入库_SetCnt())
            {
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   
                    foreach (DataGridViewCell Cell in this.dbGridView_CK.SelectedCells)
                    {
                        try
                        {
                            if (this.dbGridView_CK.Columns[Cell.ColumnIndex].HeaderText.Equals("出库单价")
                                || this.dbGridView_CK.Columns[Cell.ColumnIndex].HeaderText.Equals("出库数量")
                                || this.dbGridView_CK.Columns[Cell.ColumnIndex].HeaderText.Equals("金额"))
                            {
                                Cell.Value = Fm.Value;
                            }
                        }
                        catch (Exception exp)
                        {
                            AppServer.ShowMsg(exp.Message);
                        }
                    }                                    
                }
            }
        }

        private void dbGridView_CH_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btn添加.PerformClick();
        }

        private void STK_库存入库_Editor_KeyUp(object sender, KeyEventArgs e)
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CKCode = (string)this.cbx仓库编码.SelectedValue;
            Properties.Settings.Default.Save();
            //
            if (this.dbGridView_CK.Rows.Count == 0)
            {
                AppServer.ShowMsg("出库单没有数据，无法提交！");
                return;
            }
            //
            this.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_库存管理();
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
            model.ExAction = this.btnEnter.Tag.ToString();
            model.单据编码 = this.Tag.ToString();
            model.LoginUserCode = AppServer.LoginUserCode;
            model.MxDataXML = ((DataTable)this.dbGridView_CK.DataSource).ToXml("ar");
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.STK_库存出库_Edit(ref model);
            });
            //
            this.Cursor = Cursors.Arrow;
            //
            if (model.ExResult != 0)
            {
                try
                {
                    AppServer.ShowMsg_Error(model.ErrorMsg.Replace("\\n", "\n"));
                }
                catch (Exception exp)
                {
                    AppServer.ShowMsg(exp.Message);
                }
                return;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void dbGridView_CK_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dbGridView_CK.Columns[e.ColumnIndex].HeaderText == "出库数量")
            {
                if (this.dbGridView_CK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToDecimalDef() > this.dbGridView_CK.Rows[e.RowIndex].Cells["存货数量"].Value.ToDecimalDef())
                {
                    this.dbGridView_CK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.dbGridView_CK.Rows[e.RowIndex].Cells["存货数量"].Value;
                }
                
            }
            //
            if (this.dbGridView_CK.Columns[e.ColumnIndex].HeaderText.Equals("出库单价")
             || this.dbGridView_CK.Columns[e.ColumnIndex].HeaderText.Equals("出库数量"))
            {
                this.dbGridView_CK.Rows[e.RowIndex].Cells["出库金额"].Value = this.dbGridView_CK.Rows[e.RowIndex].Cells["出库单价"].Value.ToDecimalDef() *
                                                                        this.dbGridView_CK.Rows[e.RowIndex].Cells["出库数量"].Value.ToDecimalDef();
            }
        }

        private void STK_库存出库_Editor_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((string)this.btnEnter.Tag))
            {
                int width = Screen.PrimaryScreen.WorkingArea.Width;
                this.sltContainer.SplitterDistance = width / 7 * 3 < 600 ? 600 : width / 7 * 3;
            }
        }
    }
}

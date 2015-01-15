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
    public partial class BAS_期初库存设置 : Form
    {
        public BAS_期初库存设置()
        {
            InitializeComponent();
            //
            this.btnMod.Text = fg ? "完成期初录入(&S)" : "录入期初数据(&M)";
            //
            AppServer.SetGridViewStyle(this.dbGridView);
            this.dbGridView.GridStr(AppServer.GetTableDef("BAS_期初库存设置"));
            this.dbGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            //
            this.DataBinding_dbTreeView();
            this.DataBinding_cbx仓库编码();
           
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

        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_库存管理();
            model.类别编码 = ((DBTreeNode)e.Node).ID;
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_期初库存_List(model).Tables[0];
            });
            this.dbGridView.GoToRowByIndex(0);
            //        
            base.Cursor = Cursors.Arrow;
        }

        public void DataBinding_dbGridView(string ASortCode, int ARowIndex)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_库存管理();
            model.类别编码 = ASortCode;
            model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
            model.存货名称 = this.txt存货名称.Text.Trim();
            AppServer.UsingWcf(() =>
            {
                this.dbGridView.DataSource = AppServer.wcfClient.BAS_期初库存_List(model).Tables[0];
            });
            this.dbGridView.GoToRowByIndex(ARowIndex);
            //        
            base.Cursor = Cursors.Arrow;
        }

        private void cbx仓库编码_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
        }

        private void txt存货名称_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
                this.txt存货名称.Focus();
            }
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(this.dbTreeView.SelectedNode.ID, 0);
            this.txt存货名称.Focus();
        }

        private void dbGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dbGridView.Columns[e.ColumnIndex].HeaderText.Equals("期初单价") || this.dbGridView.Columns[e.ColumnIndex].HeaderText.Equals("期初数量"))
            {
                this.dbGridView.Rows[e.RowIndex].Cells["期初金额"].Value = this.dbGridView.Rows[e.RowIndex].Cells["期初单价"].Value.ToDecimalDef()
                                                                      * this.dbGridView.Rows[e.RowIndex].Cells["期初数量"].Value.ToDecimalDef();
            }
            //
            if ( this.dbGridView.Columns[e.ColumnIndex].HeaderText.Equals("期初单价")
                || this.dbGridView.Columns[e.ColumnIndex].HeaderText.Equals("期初数量")
                || this.dbGridView.Columns[e.ColumnIndex].HeaderText.Equals("期初金额"))
            {
                var model = new Ref_WS_STK.DataType_库存管理();
                model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
                model.货架编码 = this.dbGridView.Rows[e.RowIndex].Cells["货架编码"].Value.ToString();
                model.存货编码 = this.dbGridView.Rows[e.RowIndex].Cells["存货编码"].Value.ToString();
                model.期初单价 = this.dbGridView.Rows[e.RowIndex].Cells["期初单价"].Value.ToDecimalDef();
                model.期初数量 = this.dbGridView.Rows[e.RowIndex].Cells["期初数量"].Value.ToDecimalDef();
                model.期初金额 = this.dbGridView.Rows[e.RowIndex].Cells["期初金额"].Value.ToDecimalDef();
                model.LoginUserCode = AppServer.LoginUserCode;
                AppServer.UsingWcf(() =>
                {
                    AppServer.wcfClient.BAS_期初库存_Edit(ref model);
                });
            }   
        }

        bool fg = false;   //是否修改
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (!fg)
            {
                var model = new Ref_WS_STK.DataType_库存管理();
                model.ExAction = "Over";
                model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
                AppServer.UsingWcf(() =>
                {
                    AppServer.wcfClient.BAS_期初库存_Edit(ref model);
                });
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_Warn(model.ErrorMsg);
                    return;
                }
            }
            //
            this.fg = !this.fg;
            this.btnMod.Text = fg ? "完成期初录入(&S)" : "录入期初数据(&M)";
            this.btnSetCnt.Enabled = fg;
            this.dbGridView.Columns["期初单价"].ReadOnly = !fg;
            this.dbGridView.Columns["期初数量"].ReadOnly = !fg;
            this.dbGridView.Columns["期初金额"].ReadOnly = !fg;
            this.dbGridView.Columns["期初单价"].DefaultCellStyle.ForeColor = fg ? Color.Blue : Color.Black;
            this.dbGridView.Columns["期初数量"].DefaultCellStyle.ForeColor = fg ? Color.Blue : Color.Black;
            this.dbGridView.Columns["期初金额"].DefaultCellStyle.ForeColor = fg ? Color.Blue : Color.Black;
        }

        private void btnSetCnt_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.Rows.Count == 0 || this.dbGridView.SelectedCells.Count == 0) return;
            //
            bool fg = false;
            foreach (DataGridViewCell Cell in this.dbGridView.SelectedCells)
            {
                if (this.dbGridView.Columns[Cell.ColumnIndex].HeaderText.Equals("期初单价") || this.dbGridView.Columns[Cell.ColumnIndex].HeaderText.Equals("期初数量"))
                {
                    fg = true;
                    break;
                }
            }
            if (!fg)
            {
                AppServer.ShowMsg_Warn("所选内容没有包含期初单价和期初数量，请核对");
                return;
            }
            //            
            using (var Fm = new M02_库存管理.STK_库存入库_SetCnt())
            {
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DataGridViewCell Cell in this.dbGridView.SelectedCells)
                    {
                        if (this.dbGridView.Columns[Cell.ColumnIndex].HeaderText.Equals("期初单价") || this.dbGridView.Columns[Cell.ColumnIndex].HeaderText.Equals("期初数量"))
                        {
                            Cell.Value = Fm.Value;
                        }
                    }
                }
            }
        }

        private void dbGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && this.dbGridView.Columns[e.ColumnIndex].HeaderText.Equals("存放货架"))
            {
                this.btnBind.PerformClick();
            }
        }

        private void btnBind_Click(object sender, EventArgs e)
        {
            if (this.dbGridView.Rows.Count == 0 || this.dbGridView.SelectedCells.Count == 0) return;           
            //            
            using (var Fm = new M01_基础设置.BAS_货架设置_Select())
            {
                Fm.Select_Mod((string)this.cbx仓库编码.SelectedValue);
                if (Fm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {                  
                    foreach (DataGridViewCell Cell in this.dbGridView.SelectedCells)
                    {
                        this.dbGridView.Rows[Cell.RowIndex].Cells["存放货架"].Value = Fm.CKName;
                        this.dbGridView.Rows[Cell.RowIndex].Cells["货架编码"].Value = Fm.CKCode;
                        //
                        var model = new Ref_WS_STK.DataType_库存管理();
                        model.ExAction = "Bind";
                        model.仓库编码 = (string)this.cbx仓库编码.SelectedValue;
                        model.存货编码 = this.dbGridView.Rows[Cell.RowIndex].Cells["存货编码"].Value.ToString();
                        model.货架编码 = Fm.CKCode;
                        model.LoginUserCode = AppServer.LoginUserCode;
                        AppServer.UsingWcf(() =>
                        {
                            AppServer.wcfClient.BAS_期初库存_Edit(ref model);
                        });
                    }                   
                }
            }        
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.dbGridView.Preview("库存期初录入列表", "A4", true, String.Format("单位：长葛市恒光热电有限责任公司  存货类别：{0} ", this.dbTreeView.SelectedNode.Text), "生成日期:" + DateTime.Now.ToString(), "", "@页码");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace STK_Client.M01_基础设置
{
    public partial class BAS_储物箱设置_Bind : Form
    {
        private string CKCode = "";
        //
        public BAS_储物箱设置_Bind()
        {
            InitializeComponent();
            //
            this.Text = "绑定储物箱";
            //
            this.DataBinding_dbTreeView();
            //
            this.dbGridView_WL.GridStr(
                 "{ro=1,rno=1}"
               + "[存货编码,vi=0]"
               + "[存货名称,wh=120,al=mc]"
               + "[规格型号,wh=120,asm=1,al=mc]"
               );
            this.dbGridView_CWX.GridStr(
                  "{ro=1,rno=1}"
                + "[仓库编码,vi=0]"
                + "[仓库名称,wh=120,al=mc]"
                + "[存货编码,vi=0]"
                + "[存货名称,wh=120,al=mc]"
                + "[规格型号,wh=120,asm=1,al=mc]"
                );
            //
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
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
        }

        public void CWXBind(DataGridViewSelectedRowCollection Rows)
        {
            this.CKCode = Rows[0].Cells["仓库编码"].Value.ToString().Substring(0, 3);
            this.DataBinding_dbGridView_WL("0", 0);
            //
            DataTable tt = this.dbGridView_CWX.DataSource as DataTable;   //申请物资暂存列表
            if (tt == null)
            {
                tt = new DataTable();
                tt.ColumnEx("仓库编码/仓库名称/存货编码/存货名称/规格型号:string");
            }
            //
            DataView Dv = new DataView(this.dbGridView_CWX.DataSource as DataTable);
            //
            foreach (DataGridViewRow row in Rows)
            {
                Dv.RowFilter = String.Format("仓库编码='{0}'", row.Cells["仓库编码"].Value);
                if (Dv.Count > 0)
                {
                    continue;
                }
                tt.Rows.Add(row.Cells["仓库编码"].Value.ToString(),
                    row.Cells["仓库名称"].Value.ToString(),
                    row.Cells["存货编码"].Value.ToString(),
                    row.Cells["存货名称"].Value.ToString(),
                    row.Cells["规格型号"].Value.ToString()
                    );
            }
            this.dbGridView_CWX.DataSource = tt;
        }

        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.DataBinding_dbGridView_WL(((DBTreeNode)e.Node).ID, 0);
        }

        public void DataBinding_dbGridView_WL(string ASortCode, int ARowIndex)
        {
            base.Cursor = Cursors.WaitCursor;
            //
            var model = new Ref_WS_STK.DataType_存货();
            model.ExAction = "SlCCH";
            model.类别编码 = ASortCode;
            model.存货状态 = 0;
            model.包含下级 = this.chkShowSubCode.Checked;
            AppServer.UsingWcf(() =>
            {
                this.dbGridView_WL.DataSource = AppServer.wcfClient.BAS_存货_List(model).Tables[0];
            });
            this.dbGridView_WL.GoToRowByIndex(ARowIndex);
            //        
            base.Cursor = Cursors.Arrow;
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView_WL("0", 0);
        }

        private void btnBind_Click(object sender, EventArgs e)
        {
            if (this.dbGridView_WL.SelectedRows.Count == 0) return;
            //
            foreach(DataGridViewRow Row in this.dbGridView_CWX.SelectedRows)
            {
                Row.Cells["存货编码"].Value = this.dbGridView_WL.SelectedRows[0].Cells["存货编码"].Value;
                Row.Cells["存货名称"].Value = this.dbGridView_WL.SelectedRows[0].Cells["存货名称"].Value;
                Row.Cells["规格型号"].Value = this.dbGridView_WL.SelectedRows[0].Cells["规格型号"].Value;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in this.dbGridView_CWX.SelectedRows)
            {
                Row.Cells["存货编码"].Value = null;
                Row.Cells["存货名称"].Value = null;
                Row.Cells["规格型号"].Value = null;
            }
        }

        private void dbGridView_WL_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnBind.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dbGridView_WL.SelectedRows.Count == 0)
            {
                AppServer.ShowMsg("请选择物料");
                return;
            }
            if (this.dbGridView_CWX.SelectedRows.Count == 0)
            {
                AppServer.ShowMsg("请选择要开始绑定的储物箱");
                return;
            }
            //
            int index = this.dbGridView_CWX.CurrentRow.Index;
            foreach (DataGridViewRow Row in this.dbGridView_WL.SelectedRows)
            {
                this.dbGridView_CWX.Rows[index].Cells["存货编码"].Value = Row.Cells["存货编码"].Value;
                this.dbGridView_CWX.Rows[index].Cells["存货名称"].Value = Row.Cells["存货名称"].Value;
                this.dbGridView_CWX.Rows[index].Cells["规格型号"].Value = Row.Cells["规格型号"].Value;
                index++;
                if (index >= this.dbGridView_CWX.Rows.Count)
                {
                    break;
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var model = new Ref_WS_STK.DataType_仓库();
            model.ExAction = "Bind";
            model.MxDataXML = (this.dbGridView_CWX.DataSource as DataTable).ToXml("ar");
            AppServer.UsingWcf(() =>
            {
                AppServer.wcfClient.BAS_储物箱_Edit(ref model);
            });
            //
            if (model.ExResult != 0)
            {
                AppServer.ShowMsg_Error(model.ErrorMsg);
                return;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!AppServer.DialogMsg("是否放弃储物箱绑定信息?"))
            {
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }    
    }
}

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

namespace STK_Client.Main
{
    public partial class Man_UserMngr : Form
    {
        public Man_UserMngr()
        {
            InitializeComponent();
            //设置表格样式
            //AppServer.SetGridViewStyle(this.dbGridView);
            //
            this.dbGridView.GridStr(AppServer.GetTableDef(this.GetType().Name));
            //
            this.cbxUserState.SelectedIndex = 1;
            this.DataBinding_dbGridView(0);
        }

        public void DataBinding_dbGridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var dtm = new Ref_WS_STK.DataType_User();
                dtm.ExAction = "List";
                dtm.UserState = this.cbxUserState.SelectedIndex - 1;
                this.dbGridView.DataSource = AppServer.wcfClient.Sys_User_List(dtm).Tables[0];
                this.dbGridView.GoToRowByIndex(ACurrRowIndex);
                int count = this.dbGridView.Rows.Count;
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
        }

        private void gridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnModUser.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (var form = new Man_UserMngr_Editor())
            {
                form.Visible = false;
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(-1);
                }
            }
        }

        private void btnModUser_Click(object sender, EventArgs e)
        {
            if ((dbGridView.Rows.Count == 0) || (dbGridView.SelectedRows.Count == 0)) return;
            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            DataView dv = new DataView(this.dbGridView.DataSource as DataTable);
            dv.RowFilter = string.Format("UserCode='{0}'", sUserCode);
            if (dv.Count != 1) return;

            using (var form = new Man_UserMngr_Editor())
            {
                form.Visible = false;
                form.Editor_Mod(sUserCode, dv);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index);
                }
            }
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if ((dbGridView.Rows.Count == 0) || (dbGridView.SelectedRows.Count == 0)) return;
            if (!AppServer.DialogMsg("确认要删除当前用户吗？", "删除确认")) return;

            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            //开始删除
            base.Cursor = Cursors.WaitCursor;
            try
            {
                var dmt = new Ref_WS_STK.DataType_User();
                dmt.UserCode = sUserCode;
                dmt.ExAction = "Del";

                if (!AppServer.WcfService_Open()) return;
                //
                AppServer.wcfClient.Sys_User_Edit(ref dmt);

                if (dmt.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(dmt.ErrorMsg);
                    return;
                }
                this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index - 1);
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_SubmitError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if ((dbGridView.Rows.Count == 0) || (dbGridView.SelectedRows.Count == 0)) return;
            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            DataView dv = new DataView(this.dbGridView.DataSource as DataTable);
            dv.RowFilter = string.Format("UserCode='{0}'", sUserCode);
            if (dv.Count != 1) return;

            using (var form = new Man_UserRole())
            {
                form.Visible = false;
                form.Editor_Mod(sUserCode, dv);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnModUser.PerformClick();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void cbxUserState_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_dbGridView(0);
        }

    }
}

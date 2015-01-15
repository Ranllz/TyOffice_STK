using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STK_Client.Main
{
    public partial class Man_UserRole : Form
    {
        private string FUserCode;

        public Man_UserRole()
        {
            InitializeComponent();
            //
            this.DataBinding_ListView();
        }

        private void DataBinding_ListView()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_STK.DataType_Role();
                model.LoginUserCode = AppServer.LoginUserCode;

                DataTable table = AppServer.wcfClient.Sys_Role_List(model).Tables[0].Copy();
                this.listView.Items.Clear();
                String[] s = new String[5];
                foreach (DataRow dr in table.Rows)
                {
                    s[0] = dr["RoleName"].ToString();
                    s[1] = dr["RoleMemo"].ToString();
                    s[2] = dr["RoleID"].ToString();
                    s[3] = dr["CreateUserCode"].ToString();
                    this.listView.Items.Add(new ListViewItem(s));
                }
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

        //修改状态
        public void Editor_Mod(string AUserCode, DataView dv)
        {
            FUserCode = AUserCode;
            string sRoleList = dv[0]["RoleList"].ToString();
            string sUserName = dv[0]["UserName"].ToString();
            this.Text = string.Format("用户“{0}”的角色", sUserName);

            foreach (ListViewItem lvi in this.listView.Items)
            {
                if (("," + sRoleList + ",").IndexOf("," + lvi.SubItems[2].Text + ",") >= 0)
                {
                    lvi.Checked = true;
                }
                else
                {
                    lvi.Checked = false;
                }
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            Man_UserRole_Editor form = new Man_UserRole_Editor();
            form.Visible = false;
            form.Editor_Add();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.DataBinding_ListView();
            }
        }

        private void btnModRole_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count == 0) return;
            if (this.listView.SelectedItems[0].SubItems[3].Text == "")
            {
                AppServer.ShowMsg_Warn("您无权修改系统内置定义的角色！");
                return;
            }
            int iRoleID = int.Parse(this.listView.SelectedItems[0].SubItems[2].Text);

            var form = new Man_UserRole_Editor();
            form.Visible = false;
            form.Editor_Mod(iRoleID, this.listView.SelectedItems[0].SubItems[0].Text, this.listView.SelectedItems[0].SubItems[1].Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //修改当前Item的显示
                this.listView.SelectedItems[0].SubItems[0].Text = form.txtRoleName.Text;
                this.listView.SelectedItems[0].SubItems[1].Text = form.txtRoleMemo.Text;                 
            }
        }

        private void btnDelRole_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count == 0) return;
            if (this.listView.SelectedItems[0].SubItems[3].Text == "")
            {
                AppServer.ShowMsg_Warn("您无权修改系统内置定义的角色！");
                return;
            }
            if (!AppServer.DialogMsg("确认要删除当前角色的定义吗？", "删除确认")) return;

            int iRoleID = int.Parse(this.listView.SelectedItems[0].SubItems[2].Text);
            if (iRoleID == 0) return;

            //开始删除
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var dtm = new Ref_WS_STK.DataType_Role();
                dtm.ExAction = "Del";
                dtm.RoleID = iRoleID;
                dtm.LoginUserCode = AppServer.LoginUserCode;

                AppServer.wcfClient.Sys_Role_Edit(ref dtm);

                if (dtm.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(dtm.ErrorMsg);
                    return;
                }
                //直接删除显示
                this.listView.Items.Remove(this.listView.SelectedItems[0]);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            string sRoleList = "";
            foreach (ListViewItem lvi in this.listView.Items)
            {
                if (lvi.Checked)
                {
                    sRoleList += (String.IsNullOrEmpty(sRoleList) ? "" : ",") + lvi.SubItems[2].Text;
                }
            }

            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var dtm = new Ref_WS_STK.DataType_User();
                dtm.UserCode = FUserCode;
                dtm.RoleList = sRoleList;
                dtm.ExAction = "ModRole";

                AppServer.wcfClient.Sys_User_Edit(ref dtm);

                if (dtm.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(dtm.ErrorMsg);
                    return;
                }
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
            //
            this.DialogResult = DialogResult.OK;
        }

    }

}
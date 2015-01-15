using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Controls;

namespace STK_Client.Main
{
    public partial class Man_UserRole_Editor : Form
    {
        private int FRoleID;
        private ComboBox TComboBox = new ComboBox();

        public Man_UserRole_Editor()
        {
            InitializeComponent();
            this.DataBinding_DbTreeView();
        }

        private void DataBinding_DbTreeView()
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;

                this.dbTreeView.CheckBoxs = true;
                this.dbTreeView.MultiSelect = true;
                this.dbTreeView.NodeID = "MenuCode";
                this.dbTreeView.NodePID = "MenuPCode";
                this.dbTreeView.NodeTitle = "MenuName";
                this.dbTreeView.DataSource = AppServer.wcfClient.Sys_Menu_List(0).Tables[0];
                this.dbTreeView.BuildTrees();
                this.dbTreeView.ExpandAll();
                //选中首节点
                if (this.dbTreeView.Nodes.Count > 0)
                    this.dbTreeView.SelectedNode = (DBTreeNode)dbTreeView.Nodes[0];
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

        //增加状态
        public void Editor_Add()
        {
            this.Text = "新建角色";
            FRoleID = 0;
            this.txtRoleName.Focus();
        }

        //修改状态
        public void Editor_Mod(int ARoleID, string ARoleName, string ARoleMemo)
        {
            this.Text = "修改角色";
            FRoleID = ARoleID;
            DataTable dtMenu = null;
            try
            {
                if (!AppServer.WcfService_Open()) return;

                dtMenu = AppServer.wcfClient.Sys_Menu_List(ARoleID).Tables[0].Copy();
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_SubmitError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }

            foreach (DataRow dr in dtMenu.Rows)
            {
                TComboBox.Items.Add(dr["MenuCode"].ToString());
            }

            foreach (DBTreeNode tnTemp in dbTreeView.Nodes)
            {
                //if (tnTemp.Parent == null)
                //{
                //    SetNodeCheck(tnTemp);
                //}
                SetNodeCheck(tnTemp);
            }

            this.txtRoleName.Text = ARoleName;
            this.txtRoleMemo.Text = ARoleMemo;
            this.txtRoleName.Focus();
        }

        private void SetNodeCheck(DBTreeNode Node)
        {
            Node.Checked = ExistsNode(Node.ID);
            if (Node.Nodes.Count != 0)
            {
                foreach (DBTreeNode tnTemp in Node.Nodes)
                {
                    SetNodeCheck(tnTemp);
                }
            }
            //else
            //{
            //    Node.Checked = ExistsNode(Node.ID);
            //}
        }

        private bool ExistsNode(string nodeID)
        {
            for (int i = 0; i < TComboBox.Items.Count; i++)
            {
                if (nodeID == TComboBox.Items[i].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void dbTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeViewCheck.CheckControl(e);
            DBTreeNode node = (DBTreeNode)e.Node;
            if (e.Node.Checked)
            {
                TComboBox.Items.Remove(node.ID);
                TComboBox.Items.Add(node.ID);

            }
            else
            {
                TComboBox.Items.Remove(node.ID);
            }
           
        }

        private void dbTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            //if (e.Node == this.dbTreeView.Nodes[0])
            //    e.Cancel = true;
            //else
            //    e.Cancel = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtRoleName.Text.Trim() == "")
            {
                AppServer.ShowMsg_Warn("角色名称不能为空　　", "数据校验");
                this.txtRoleName.Focus();
                return;
            }
            string sRoleList = "";
            for (int i = 0; i < TComboBox.Items.Count; i++)
            {
                sRoleList += TComboBox.Items[i].ToString() + ",";
            }

            this.DialogResult = DialogResult.None;            
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var dtm = new Ref_WS_STK.DataType_Role();
                dtm.RoleID = FRoleID;
                dtm.RoleName = this.txtRoleName.Text;
                dtm.RoleMemo = this.txtRoleMemo.Text;
                dtm.RoleMenu = sRoleList;
                dtm.LoginUserCode = AppServer.LoginUserCode;
                AppServer.wcfClient.Sys_Role_Edit(ref dtm);

                if (dtm.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(dtm.ErrorMsg);
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
            }
            //
            this.DialogResult = DialogResult.OK;
        }
    }

    public static class TreeViewCheck
    {
        /// <summary>
        /// 系列节点 Checked 属性控制
        /// </summary>
        /// <param name="e"></param>
        public static void CheckControl(TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node != null && !Convert.IsDBNull(e.Node))
                {
                    CheckParentNode(e.Node);
                    if (e.Node.Nodes.Count > 0)
                    {
                        CheckAllChildNodes(e.Node, e.Node.Checked);
                    }
                    SetNodeCheckStatus(e.Node, e.Node.Checked);
                    SetNodeStyle(e.Node);
                }
            }
        }

        #region 私有方法

        //改变所有子节点的状态
        private static void CheckAllChildNodes(TreeNode pn, bool IsChecked)
        {
            foreach (TreeNode tn in pn.Nodes)
            {
                tn.Checked = IsChecked;

                if (tn.Nodes.Count > 0)
                {
                    CheckAllChildNodes(tn, IsChecked);
                }
            }
        }

        //改变父节点的选中状态，此处为所有子节点不选中时才取消父节点选中，可以根据需要修改
        private static void CheckParentNode(TreeNode curNode)
        {
            bool bChecked = false;

            if (curNode.Parent != null)
            {
                foreach (TreeNode node in curNode.Parent.Nodes)
                {
                    if (node.Checked)
                    {
                        bChecked = true;
                        break;
                    }
                }

                if (bChecked)
                {
                    curNode.Parent.Checked = true;
                    CheckParentNode(curNode.Parent);
                }
                else
                {
                    curNode.Parent.Checked = false;
                    CheckParentNode(curNode.Parent);
                }
            }
        }
        private static void SetNodeCheckStatus(TreeNode tn, bool Checked)
        {

            if (tn == null) return;
            foreach (TreeNode tnChild in tn.Nodes)
            {

                tnChild.Checked = Checked;

                SetNodeCheckStatus(tnChild, Checked);

            }
            TreeNode tnParent = tn;
        }

        private static void SetNodeStyle(TreeNode Node)
        {
            int NodeCount = 0;
            if (Node.Nodes.Count != 0)
            {
                foreach (TreeNode tnTemp in Node.Nodes)
                {
                    if (tnTemp.Checked == true)
                        NodeCount++;
                }

                if (NodeCount == Node.Nodes.Count)
                {
                    Node.Checked = true;
                    Node.ExpandAll();
                    Node.ForeColor = Color.Black;
                }
                else if (NodeCount == 0)
                {
                    Node.Checked = false;
                    Node.Collapse();
                    Node.ForeColor = Color.Black;
                }
                else
                {
                    Node.Checked = true;
                    Node.ForeColor = Color.Gray;
                }
            }
            //当前节点选择完后，判断父节点的状态，调用此方法递归。   
            if (Node.Parent != null)
                SetNodeStyle(Node.Parent);
        }   
        #endregion

    }
}

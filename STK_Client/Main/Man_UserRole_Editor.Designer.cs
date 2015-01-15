namespace STK_Client.Main
{
    partial class Man_UserRole_Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRoleMemo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbTreeView = new TY.Controls.DBTreeView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRoleMemo
            // 
            this.txtRoleMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoleMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoleMemo.Location = new System.Drawing.Point(85, 46);
            this.txtRoleMemo.MaxLength = 50;
            this.txtRoleMemo.Name = "txtRoleMemo";
            this.txtRoleMemo.Size = new System.Drawing.Size(319, 21);
            this.txtRoleMemo.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 97;
            this.label12.Text = "角色描述：";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoleName.Location = new System.Drawing.Point(85, 14);
            this.txtRoleName.MaxLength = 50;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(319, 21);
            this.txtRoleName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 96;
            this.label1.Text = "角色名称：";
            // 
            // dbTreeView
            // 
            this.dbTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dbTreeView.CheckBoxs = false;
            this.dbTreeView.CheckMode = TY.Controls.CheckMode.None;
            this.dbTreeView.DataSource = null;
            this.dbTreeView.HideSelection = false;
            this.dbTreeView.ImageIndex = -1;
            this.dbTreeView.ImageList = null;
            this.dbTreeView.ItemHeight = 14;
            this.dbTreeView.Location = new System.Drawing.Point(26, 79);
            this.dbTreeView.MultiSelect = false;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = "MenuCode";
            this.dbTreeView.NodePID = "MenuPCode";
            this.dbTreeView.NodeTitle = "MenuName";
            this.dbTreeView.SelectedImageIndex = -1;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(378, 305);
            this.dbTreeView.TabIndex = 98;
            this.dbTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.dbTreeView_AfterCheck);
            this.dbTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.dbTreeView_BeforeCollapse);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(232, 395);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 27);
            this.btnOK.TabIndex = 99;
            this.btnOK.Text = "确定(&E)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 27);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Man_UserRole_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 434);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dbTreeView);
            this.Controls.Add(this.txtRoleMemo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Man_UserRole_Editor";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Man_UserRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private TY.Controls.DBTreeView dbTreeView;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtRoleMemo;
        public System.Windows.Forms.TextBox txtRoleName;
    }
}
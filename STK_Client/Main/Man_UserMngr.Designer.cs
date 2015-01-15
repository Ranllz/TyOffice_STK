namespace STK_Client.Main
{
    partial class Man_UserMngr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnModUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbxUserState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnDelUser);
            this.panel1.Controls.Add(this.btnModUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 30);
            this.panel1.TabIndex = 50;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(695, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.Control;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRight.Location = new System.Drawing.Point(240, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(95, 28);
            this.btnRight.TabIndex = 14;
            this.btnRight.Text = "权限设置(&R)";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelUser.Location = new System.Drawing.Point(160, 0);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(80, 28);
            this.btnDelUser.TabIndex = 13;
            this.btnDelUser.Text = "删除(&D)";
            this.btnDelUser.UseVisualStyleBackColor = false;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnModUser
            // 
            this.btnModUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnModUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModUser.Location = new System.Drawing.Point(80, 0);
            this.btnModUser.Name = "btnModUser";
            this.btnModUser.Size = new System.Drawing.Size(80, 28);
            this.btnModUser.TabIndex = 12;
            this.btnModUser.Text = "修改(&M)";
            this.btnModUser.UseVisualStyleBackColor = false;
            this.btnModUser.Click += new System.EventHandler(this.btnModUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(80, 28);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "新建(&A)";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dbGridView
            // 
            this.dbGridView.AllowUserToAddRows = false;
            this.dbGridView.AllowUserToDeleteRows = false;
            this.dbGridView.AllowUserToResizeRows = false;
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dbGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dbGridView.ColumnHeadersHeight = 28;
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.EnableHeadersVisualStyles = false;
            this.dbGridView.Location = new System.Drawing.Point(0, 71);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dbGridView.RowHeadersWidth = 20;
            this.dbGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbGridView.RowTemplate.Height = 20;
            this.dbGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGridView.Size = new System.Drawing.Size(777, 478);
            this.dbGridView.TabIndex = 245;
            this.dbGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridView_CellDoubleClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(777, 41);
            this.lblTitle.TabIndex = 246;
            this.lblTitle.Text = "用户管理";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxUserState
            // 
            this.cbxUserState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUserState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserState.FormattingEnabled = true;
            this.cbxUserState.Items.AddRange(new object[] {
            "所有的",
            "在职",
            "离职",
            "辞退",
            "退休"});
            this.cbxUserState.Location = new System.Drawing.Point(690, 46);
            this.cbxUserState.Name = "cbxUserState";
            this.cbxUserState.Size = new System.Drawing.Size(81, 20);
            this.cbxUserState.TabIndex = 247;
            this.cbxUserState.SelectedIndexChanged += new System.EventHandler(this.cbxUserState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 248;
            this.label1.Text = "显示用户状态：";
            // 
            // Man_UserMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxUserState);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "Man_UserMngr";
            this.ShowInTaskbar = false;
            this.Text = "用户管理";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnModUser;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnAddUser;
        internal System.Windows.Forms.DataGridView dbGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbxUserState;
        private System.Windows.Forms.Label label1;
    }
}
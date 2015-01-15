namespace STK_Client.M01_基础设置
{
    partial class BAS_存货类别设置_Select
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS_存货类别设置_Select));
            this.dbTreeView = new TY.Controls.DBTreeView();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbTreeView
            // 
            this.dbTreeView.CheckBoxs = false;
            this.dbTreeView.CheckMode = TY.Controls.CheckMode.None;
            this.dbTreeView.DataSource = null;
            this.dbTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTreeView.HideSelection = false;
            this.dbTreeView.ImageIndex = 1;
            this.dbTreeView.ImageList = this.iglTree;
            this.dbTreeView.ItemHeight = 18;
            this.dbTreeView.Location = new System.Drawing.Point(0, 0);
            this.dbTreeView.MultiSelect = true;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = null;
            this.dbTreeView.NodePID = null;
            this.dbTreeView.NodeTitle = null;
            this.dbTreeView.SelectedImageIndex = 0;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(457, 477);
            this.dbTreeView.TabIndex = 6;
            this.dbTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseDoubleClick);
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "stop_blue16.bmp");
            this.iglTree.Images.SetKeyName(2, "AddToFavorites.bmp");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 477);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 40);
            this.panel4.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnClose.Location = new System.Drawing.Point(135, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "取消(&C)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnSelect.Location = new System.Drawing.Point(246, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 28);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择(&S)";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // BAS_存货类别设置_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 517);
            this.Controls.Add(this.dbTreeView);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "BAS_存货类别设置_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M02_商品类别设置_Select";
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TY.Controls.DBTreeView dbTreeView;
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
    }
}
namespace STK_Client.M01_基础设置
{
    partial class BAS_存货设置
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAS_存货设置));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btn设置存放仓库 = new System.Windows.Forms.Button();
            this.btn修改状态 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx类别状态 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl物资 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbTreeView = new TY.Controls.DBTreeView();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnPrint);
            this.pnlTop.Controls.Add(this.btn设置存放仓库);
            this.pnlTop.Controls.Add(this.btn修改状态);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnDel);
            this.pnlTop.Controls.Add(this.btnMod);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(846, 30);
            this.pnlTop.TabIndex = 1;
            // 
            // btn设置存放仓库
            // 
            this.btn设置存放仓库.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn设置存放仓库.Font = new System.Drawing.Font("宋体", 9F);
            this.btn设置存放仓库.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn设置存放仓库.Location = new System.Drawing.Point(315, 0);
            this.btn设置存放仓库.Name = "btn设置存放仓库";
            this.btn设置存放仓库.Size = new System.Drawing.Size(90, 28);
            this.btn设置存放仓库.TabIndex = 6;
            this.btn设置存放仓库.Text = "设置所属仓库";
            this.btn设置存放仓库.UseVisualStyleBackColor = false;
            this.btn设置存放仓库.Click += new System.EventHandler(this.btn设置存放仓库_Click);
            // 
            // btn修改状态
            // 
            this.btn修改状态.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改状态.Font = new System.Drawing.Font("宋体", 9F);
            this.btn修改状态.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn修改状态.Location = new System.Drawing.Point(225, 0);
            this.btn修改状态.Name = "btn修改状态";
            this.btn修改状态.Size = new System.Drawing.Size(90, 28);
            this.btn修改状态.TabIndex = 5;
            this.btn修改状态.Text = "修改状态";
            this.btn修改状态.UseVisualStyleBackColor = false;
            this.btn修改状态.Click += new System.EventHandler(this.btn修改状态_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClose.Location = new System.Drawing.Point(769, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDel.Font = new System.Drawing.Font("宋体", 9F);
            this.btnDel.Location = new System.Drawing.Point(150, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 28);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMod
            // 
            this.btnMod.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMod.Font = new System.Drawing.Font("宋体", 9F);
            this.btnMod.Location = new System.Drawing.Point(75, 0);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 28);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "修改(&M)";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Font = new System.Drawing.Font("宋体", 9F);
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增(&N)";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbx类别状态);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl物资);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 35);
            this.panel2.TabIndex = 0;
            // 
            // cbx类别状态
            // 
            this.cbx类别状态.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx类别状态.FormattingEnabled = true;
            this.cbx类别状态.Items.AddRange(new object[] {
            "所有的",
            "下架的",
            "在售的",
            "促销的"});
            this.cbx类别状态.Location = new System.Drawing.Point(101, 7);
            this.cbx类别状态.Name = "cbx类别状态";
            this.cbx类别状态.Size = new System.Drawing.Size(85, 20);
            this.cbx类别状态.TabIndex = 248;
            this.cbx类别状态.SelectedIndexChanged += new System.EventHandler(this.cbx类别状态_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 249;
            this.label4.Text = "显示存货状态：";
            // 
            // lbl物资
            // 
            this.lbl物资.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl物资.AutoSize = true;
            this.lbl物资.ForeColor = System.Drawing.Color.Teal;
            this.lbl物资.Location = new System.Drawing.Point(702, 11);
            this.lbl物资.Name = "lbl物资";
            this.lbl物资.Size = new System.Drawing.Size(131, 12);
            this.lbl物资.TabIndex = 10;
            this.lbl物资.Text = "    共有 99999 条记录";
            this.lbl物资.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(846, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "存货信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dbTreeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 465);
            this.panel1.TabIndex = 9;
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
            this.dbTreeView.Size = new System.Drawing.Size(226, 465);
            this.dbTreeView.TabIndex = 249;
            this.dbTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dbTreeView_AfterSelect);
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(226, 105);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 465);
            this.splitter1.TabIndex = 244;
            this.splitter1.TabStop = false;
            // 
            // dbGridView
            // 
            this.dbGridView.AllowUserToAddRows = false;
            this.dbGridView.AllowUserToDeleteRows = false;
            this.dbGridView.AllowUserToResizeRows = false;
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dbGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dbGridView.ColumnHeadersHeight = 28;
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.EnableHeadersVisualStyles = false;
            this.dbGridView.Location = new System.Drawing.Point(228, 105);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dbGridView.RowHeadersWidth = 20;
            this.dbGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbGridView.RowTemplate.Height = 20;
            this.dbGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGridView.Size = new System.Drawing.Size(618, 465);
            this.dbGridView.TabIndex = 245;
            this.dbGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridView_CellContentClick);
            this.dbGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbGridView_CellMouseDoubleClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Font = new System.Drawing.Font("宋体", 9F);
            this.btnPrint.Location = new System.Drawing.Point(694, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 28);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // BAS_存货设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 570);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.Name = "BAS_存货设置";
            this.Text = "存货设置";
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl物资;
        private System.Windows.Forms.ComboBox cbx类别状态;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        internal System.Windows.Forms.DataGridView dbGridView;
        private TY.Controls.DBTreeView dbTreeView;
        private System.Windows.Forms.Button btn修改状态;
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Button btn设置存放仓库;
        private System.Windows.Forms.Button btnPrint;
    }
}
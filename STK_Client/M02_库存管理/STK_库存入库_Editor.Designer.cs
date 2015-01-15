namespace STK_Client.M02_库存管理
{
    partial class STK_库存入库_Editor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STK_库存入库_Editor));
            this.btn清空 = new System.Windows.Forms.Button();
            this.btn添加 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.dbGridView_RK = new System.Windows.Forms.DataGridView();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btnSetCnt = new System.Windows.Forms.Button();
            this.btnBind = new System.Windows.Forms.Button();
            this.sltContainer = new System.Windows.Forms.SplitContainer();
            this.dbGridView_CH = new System.Windows.Forms.DataGridView();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.txt存货名称 = new System.Windows.Forms.TextBox();
            this.btn查询 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dbTreeView = new TY.Controls.DBTreeView();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbx供应商编码 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp业务日期 = new System.Windows.Forms.DateTimePicker();
            this.txt审核人 = new System.Windows.Forms.TextBox();
            this.txt原始单号 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx仓库编码 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt备注 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt制单人 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView_RK)).BeginInit();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sltContainer)).BeginInit();
            this.sltContainer.Panel1.SuspendLayout();
            this.sltContainer.Panel2.SuspendLayout();
            this.sltContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView_CH)).BeginInit();
            this.pnlQuery.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn清空
            // 
            this.btn清空.BackColor = System.Drawing.SystemColors.Control;
            this.btn清空.Location = new System.Drawing.Point(170, 4);
            this.btn清空.Name = "btn清空";
            this.btn清空.Size = new System.Drawing.Size(75, 28);
            this.btn清空.TabIndex = 2;
            this.btn清空.Text = "清空";
            this.btn清空.UseVisualStyleBackColor = false;
            this.btn清空.Click += new System.EventHandler(this.btn清空_Click);
            // 
            // btn添加
            // 
            this.btn添加.BackColor = System.Drawing.SystemColors.Control;
            this.btn添加.Location = new System.Drawing.Point(11, 4);
            this.btn添加.Name = "btn添加";
            this.btn添加.Size = new System.Drawing.Size(75, 28);
            this.btn添加.TabIndex = 2;
            this.btn添加.Text = "添加";
            this.btn添加.UseVisualStyleBackColor = false;
            this.btn添加.Click += new System.EventHandler(this.btn添加_Click);
            // 
            // btn删除
            // 
            this.btn删除.BackColor = System.Drawing.SystemColors.Control;
            this.btn删除.Location = new System.Drawing.Point(91, 4);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 2;
            this.btn删除.Text = "删除";
            this.btn删除.UseVisualStyleBackColor = false;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // dbGridView_RK
            // 
            this.dbGridView_RK.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView_RK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridView_RK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView_RK.Location = new System.Drawing.Point(0, 36);
            this.dbGridView_RK.Name = "dbGridView_RK";
            this.dbGridView_RK.RowTemplate.Height = 23;
            this.dbGridView_RK.Size = new System.Drawing.Size(420, 380);
            this.dbGridView_RK.TabIndex = 2;
            this.dbGridView_RK.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbGridView_RK_CellDoubleClick);
            this.dbGridView_RK.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridView_RK_CellValueChanged);
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.Silver;
            this.pnlTool.Controls.Add(this.btnSetCnt);
            this.pnlTool.Controls.Add(this.btnBind);
            this.pnlTool.Controls.Add(this.btn清空);
            this.pnlTool.Controls.Add(this.btn删除);
            this.pnlTool.Controls.Add(this.btn添加);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(420, 36);
            this.pnlTool.TabIndex = 1;
            // 
            // btnSetCnt
            // 
            this.btnSetCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCnt.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetCnt.Location = new System.Drawing.Point(253, 4);
            this.btnSetCnt.Name = "btnSetCnt";
            this.btnSetCnt.Size = new System.Drawing.Size(75, 28);
            this.btnSetCnt.TabIndex = 4;
            this.btnSetCnt.Text = "设置数量";
            this.btnSetCnt.UseVisualStyleBackColor = false;
            this.btnSetCnt.Click += new System.EventHandler(this.btnSetCnt_Click);
            // 
            // btnBind
            // 
            this.btnBind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBind.BackColor = System.Drawing.SystemColors.Control;
            this.btnBind.Location = new System.Drawing.Point(334, 4);
            this.btnBind.Name = "btnBind";
            this.btnBind.Size = new System.Drawing.Size(75, 28);
            this.btnBind.TabIndex = 3;
            this.btnBind.Text = "选择货架";
            this.btnBind.UseVisualStyleBackColor = false;
            this.btnBind.Click += new System.EventHandler(this.btnBind_Click);
            // 
            // sltContainer
            // 
            this.sltContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sltContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sltContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sltContainer.Location = new System.Drawing.Point(0, 155);
            this.sltContainer.Name = "sltContainer";
            // 
            // sltContainer.Panel1
            // 
            this.sltContainer.Panel1.AutoScroll = true;
            this.sltContainer.Panel1.Controls.Add(this.dbGridView_CH);
            this.sltContainer.Panel1.Controls.Add(this.pnlQuery);
            this.sltContainer.Panel1.Controls.Add(this.splitter1);
            this.sltContainer.Panel1.Controls.Add(this.panel5);
            this.sltContainer.Panel1MinSize = 0;
            // 
            // sltContainer.Panel2
            // 
            this.sltContainer.Panel2.Controls.Add(this.dbGridView_RK);
            this.sltContainer.Panel2.Controls.Add(this.pnlTool);
            this.sltContainer.Panel2MinSize = 0;
            this.sltContainer.Size = new System.Drawing.Size(1099, 418);
            this.sltContainer.SplitterDistance = 673;
            this.sltContainer.TabIndex = 8;
            // 
            // dbGridView_CH
            // 
            this.dbGridView_CH.AllowUserToAddRows = false;
            this.dbGridView_CH.AllowUserToDeleteRows = false;
            this.dbGridView_CH.AllowUserToResizeRows = false;
            this.dbGridView_CH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView_CH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dbGridView_CH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView_CH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dbGridView_CH.ColumnHeadersHeight = 28;
            this.dbGridView_CH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView_CH.DefaultCellStyle = dataGridViewCellStyle5;
            this.dbGridView_CH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView_CH.EnableHeadersVisualStyles = false;
            this.dbGridView_CH.Location = new System.Drawing.Point(152, 36);
            this.dbGridView_CH.Name = "dbGridView_CH";
            this.dbGridView_CH.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView_CH.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dbGridView_CH.RowHeadersWidth = 20;
            this.dbGridView_CH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbGridView_CH.RowTemplate.Height = 20;
            this.dbGridView_CH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGridView_CH.Size = new System.Drawing.Size(519, 380);
            this.dbGridView_CH.TabIndex = 247;
            this.dbGridView_CH.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbGridView_CH_CellMouseDoubleClick);
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.Color.Silver;
            this.pnlQuery.Controls.Add(this.txt存货名称);
            this.pnlQuery.Controls.Add(this.btn查询);
            this.pnlQuery.Controls.Add(this.label3);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(152, 0);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(519, 36);
            this.pnlQuery.TabIndex = 248;
            // 
            // txt存货名称
            // 
            this.txt存货名称.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt存货名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt存货名称.ForeColor = System.Drawing.Color.Blue;
            this.txt存货名称.Location = new System.Drawing.Point(75, 8);
            this.txt存货名称.Name = "txt存货名称";
            this.txt存货名称.Size = new System.Drawing.Size(336, 21);
            this.txt存货名称.TabIndex = 3;
            this.txt存货名称.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt存货名称_KeyDown);
            // 
            // btn查询
            // 
            this.btn查询.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn查询.BackColor = System.Drawing.SystemColors.Control;
            this.btn查询.Location = new System.Drawing.Point(431, 4);
            this.btn查询.Name = "btn查询";
            this.btn查询.Size = new System.Drawing.Size(75, 28);
            this.btn查询.TabIndex = 2;
            this.btn查询.Text = "查询";
            this.btn查询.UseVisualStyleBackColor = false;
            this.btn查询.Click += new System.EventHandler(this.btn查询_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "查询存货：";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(150, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 416);
            this.splitter1.TabIndex = 246;
            this.splitter1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dbTreeView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 416);
            this.panel5.TabIndex = 0;
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
            this.dbTreeView.Size = new System.Drawing.Size(150, 416);
            this.dbTreeView.TabIndex = 251;
            this.dbTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dbTreeView_AfterSelect);
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "stop_blue16.bmp");
            this.iglTree.Images.SetKeyName(2, "AddToFavorites.bmp");
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCancel.Location = new System.Drawing.Point(404, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnter.Font = new System.Drawing.Font("宋体", 12F);
            this.btnEnter.Location = new System.Drawing.Point(582, 6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 28);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "保存(Ctrl+S)";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 40);
            this.panel1.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.LightBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1099, 40);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "编 制 入 库 单";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbx供应商编码);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dtp业务日期);
            this.panel4.Controls.Add(this.txt审核人);
            this.panel4.Controls.Add(this.txt原始单号);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cbx仓库编码);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt备注);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt制单人);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 115);
            this.panel4.TabIndex = 260;
            // 
            // cbx供应商编码
            // 
            this.cbx供应商编码.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx供应商编码.BackColor = System.Drawing.SystemColors.Control;
            this.cbx供应商编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx供应商编码.ForeColor = System.Drawing.Color.Blue;
            this.cbx供应商编码.FormattingEnabled = true;
            this.cbx供应商编码.Location = new System.Drawing.Point(74, 13);
            this.cbx供应商编码.Margin = new System.Windows.Forms.Padding(2);
            this.cbx供应商编码.Name = "cbx供应商编码";
            this.cbx供应商编码.Size = new System.Drawing.Size(604, 20);
            this.cbx供应商编码.TabIndex = 272;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 273;
            this.label6.Text = "供应商：";
            // 
            // dtp业务日期
            // 
            this.dtp业务日期.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp业务日期.CustomFormat = "yyyy年MM月dd日";
            this.dtp业务日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp业务日期.Location = new System.Drawing.Point(752, 13);
            this.dtp业务日期.Name = "dtp业务日期";
            this.dtp业务日期.Size = new System.Drawing.Size(121, 21);
            this.dtp业务日期.TabIndex = 261;
            // 
            // txt审核人
            // 
            this.txt审核人.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt审核人.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt审核人.Location = new System.Drawing.Point(943, 46);
            this.txt审核人.Name = "txt审核人";
            this.txt审核人.ReadOnly = true;
            this.txt审核人.Size = new System.Drawing.Size(144, 21);
            this.txt审核人.TabIndex = 270;
            // 
            // txt原始单号
            // 
            this.txt原始单号.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt原始单号.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt原始单号.ForeColor = System.Drawing.Color.Blue;
            this.txt原始单号.Location = new System.Drawing.Point(943, 13);
            this.txt原始单号.Name = "txt原始单号";
            this.txt原始单号.Size = new System.Drawing.Size(144, 21);
            this.txt原始单号.TabIndex = 260;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(907, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 271;
            this.label5.Text = "审核：";
            // 
            // cbx仓库编码
            // 
            this.cbx仓库编码.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx仓库编码.BackColor = System.Drawing.SystemColors.Control;
            this.cbx仓库编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx仓库编码.ForeColor = System.Drawing.Color.Blue;
            this.cbx仓库编码.FormattingEnabled = true;
            this.cbx仓库编码.Location = new System.Drawing.Point(74, 46);
            this.cbx仓库编码.Margin = new System.Windows.Forms.Padding(2);
            this.cbx仓库编码.Name = "cbx仓库编码";
            this.cbx仓库编码.Size = new System.Drawing.Size(604, 20);
            this.cbx仓库编码.TabIndex = 267;
            this.cbx仓库编码.SelectedIndexChanged += new System.EventHandler(this.cbx仓库编码_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 50);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 269;
            this.label20.Text = "入库仓库：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 265;
            this.label4.Text = "备注：";
            // 
            // txt备注
            // 
            this.txt备注.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt备注.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt备注.ForeColor = System.Drawing.Color.Blue;
            this.txt备注.Location = new System.Drawing.Point(75, 80);
            this.txt备注.Name = "txt备注";
            this.txt备注.Size = new System.Drawing.Size(1012, 21);
            this.txt备注.TabIndex = 264;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 263;
            this.label2.Text = "原始单号：";
            // 
            // txt制单人
            // 
            this.txt制单人.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt制单人.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt制单人.Location = new System.Drawing.Point(752, 46);
            this.txt制单人.Name = "txt制单人";
            this.txt制单人.ReadOnly = true;
            this.txt制单人.Size = new System.Drawing.Size(121, 21);
            this.txt制单人.TabIndex = 260;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(700, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 263;
            this.label7.Text = "制单人：";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 262;
            this.label8.Text = "业务日期：";
            // 
            // STK_库存入库_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 613);
            this.Controls.Add(this.sltContainer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "STK_库存入库_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入库单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.STK_库存入库_Editor_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.STK_库存入库_Editor_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView_RK)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.sltContainer.Panel1.ResumeLayout(false);
            this.sltContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sltContainer)).EndInit();
            this.sltContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView_CH)).EndInit();
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn清空;
        private System.Windows.Forms.Button btn添加;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.DataGridView dbGridView_RK;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.SplitContainer sltContainer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbx供应商编码;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp业务日期;
        private System.Windows.Forms.TextBox txt审核人;
        private System.Windows.Forms.TextBox txt原始单号;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx仓库编码;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt备注;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt制单人;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private TY.Controls.DBTreeView dbTreeView;
        private System.Windows.Forms.Splitter splitter1;
        internal System.Windows.Forms.DataGridView dbGridView_CH;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.TextBox txt存货名称;
        private System.Windows.Forms.Button btn查询;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Button btnBind;
        private System.Windows.Forms.Button btnSetCnt;
    }
}
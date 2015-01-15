namespace STK_Client.M02_库存管理
{
    partial class STK_库存入库
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk所有未审核 = new System.Windows.Forms.CheckBox();
            this.txt单据编码 = new System.Windows.Forms.TextBox();
            this.cbx仓库编码 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn查询 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn打印 = new System.Windows.Forms.Button();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chk所有未审核);
            this.panel2.Controls.Add(this.txt单据编码);
            this.panel2.Controls.Add(this.cbx仓库编码);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtp结束时间);
            this.panel2.Controls.Add(this.dtp开始时间);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn查询);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("宋体", 9F);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 30);
            this.panel2.TabIndex = 15;
            // 
            // chk所有未审核
            // 
            this.chk所有未审核.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk所有未审核.AutoSize = true;
            this.chk所有未审核.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chk所有未审核.Location = new System.Drawing.Point(415, 7);
            this.chk所有未审核.Name = "chk所有未审核";
            this.chk所有未审核.Size = new System.Drawing.Size(108, 16);
            this.chk所有未审核.TabIndex = 280;
            this.chk所有未审核.Text = "查询所有未审核";
            this.chk所有未审核.UseVisualStyleBackColor = true;
            this.chk所有未审核.CheckedChanged += new System.EventHandler(this.chk所有未审核_CheckedChanged);
            // 
            // txt单据编码
            // 
            this.txt单据编码.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt单据编码.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt单据编码.Location = new System.Drawing.Point(265, 5);
            this.txt单据编码.Name = "txt单据编码";
            this.txt单据编码.Size = new System.Drawing.Size(131, 21);
            this.txt单据编码.TabIndex = 279;
            this.txt单据编码.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt单据编码_KeyDown);
            // 
            // cbx仓库编码
            // 
            this.cbx仓库编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx仓库编码.FormattingEnabled = true;
            this.cbx仓库编码.Location = new System.Drawing.Point(63, 5);
            this.cbx仓库编码.Name = "cbx仓库编码";
            this.cbx仓库编码.Size = new System.Drawing.Size(130, 20);
            this.cbx仓库编码.TabIndex = 278;
            this.cbx仓库编码.SelectedIndexChanged += new System.EventHandler(this.cbx仓库编码_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(204, 9);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 12);
            this.label32.TabIndex = 275;
            this.label32.Text = "入库单号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 275;
            this.label5.Text = "查询仓库：";
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(731, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 274;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(592, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(121, 21);
            this.dtp开始时间.TabIndex = 273;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 12);
            this.label2.TabIndex = 272;
            this.label2.Text = "入库时间从                     至";
            // 
            // btn查询
            // 
            this.btn查询.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn查询.AutoSize = true;
            this.btn查询.Font = new System.Drawing.Font("宋体", 9F);
            this.btn查询.Location = new System.Drawing.Point(896, 2);
            this.btn查询.Name = "btn查询";
            this.btn查询.Size = new System.Drawing.Size(75, 26);
            this.btn查询.TabIndex = 1;
            this.btn查询.Text = "查询(&Q)";
            this.btn查询.UseVisualStyleBackColor = false;
            this.btn查询.Click += new System.EventHandler(this.btn查询_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn打印);
            this.panel1.Controls.Add(this.btn查看);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnMod);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 30);
            this.panel1.TabIndex = 13;
            // 
            // btn打印
            // 
            this.btn打印.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn打印.Font = new System.Drawing.Font("宋体", 9F);
            this.btn打印.Location = new System.Drawing.Point(830, 0);
            this.btn打印.Name = "btn打印";
            this.btn打印.Size = new System.Drawing.Size(75, 28);
            this.btn打印.TabIndex = 7;
            this.btn打印.Text = "打印(&P)";
            this.btn打印.UseVisualStyleBackColor = false;
            this.btn打印.Click += new System.EventHandler(this.btn打印_Click);
            // 
            // btn查看
            // 
            this.btn查看.AutoSize = true;
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Font = new System.Drawing.Font("宋体", 9F);
            this.btn查看.Location = new System.Drawing.Point(225, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 6;
            this.btn查看.Text = "查看(&V)";
            this.btn查看.UseVisualStyleBackColor = false;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClose.Location = new System.Drawing.Point(905, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 5;
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
            this.btnAdd.Text = "新建(&A)";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "入 库 单 列 表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbGridView
            // 
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.Location = new System.Drawing.Point(0, 100);
            this.dbGridView.MultiSelect = false;
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.RowTemplate.Height = 23;
            this.dbGridView.Size = new System.Drawing.Size(982, 467);
            this.dbGridView.TabIndex = 16;
            this.dbGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbGridView_CellMouseDoubleClick);
            // 
            // STK_库存入库
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 567);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "STK_库存入库";
            this.Text = "入库单列表";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt单据编码;
        private System.Windows.Forms.ComboBox cbx仓库编码;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn查询;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn打印;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dbGridView;
        private System.Windows.Forms.CheckBox chk所有未审核;
    }
}
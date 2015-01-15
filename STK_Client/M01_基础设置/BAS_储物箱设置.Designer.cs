namespace STK_Client.M01_基础设置
{
    partial class BAS_储物箱设置
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
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBind = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbx上级编码 = new System.Windows.Forms.ComboBox();
            this.cbx仓库编码 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt仓库名称 = new System.Windows.Forms.TextBox();
            this.lbl查询记录 = new System.Windows.Forms.Label();
            this.btn查询 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGridView
            // 
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.Location = new System.Drawing.Point(0, 105);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.RowTemplate.Height = 23;
            this.dbGridView.Size = new System.Drawing.Size(984, 434);
            this.dbGridView.TabIndex = 1;
            this.dbGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbGridView_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBind);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnMod);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 30);
            this.panel1.TabIndex = 2;
            // 
            // btnBind
            // 
            this.btnBind.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBind.Font = new System.Drawing.Font("宋体", 9F);
            this.btnBind.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBind.Location = new System.Drawing.Point(225, 0);
            this.btnBind.Name = "btnBind";
            this.btnBind.Size = new System.Drawing.Size(79, 28);
            this.btnBind.TabIndex = 3;
            this.btnBind.Text = "绑定物料(&B)";
            this.btnBind.UseVisualStyleBackColor = false;
            this.btnBind.Visible = false;
            this.btnBind.Click += new System.EventHandler(this.btnBind_Click);
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
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClose.Location = new System.Drawing.Point(907, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.cbx上级编码);
            this.panel2.Controls.Add(this.cbx仓库编码);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt仓库名称);
            this.panel2.Controls.Add(this.lbl查询记录);
            this.panel2.Controls.Add(this.btn查询);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 35);
            this.panel2.TabIndex = 0;
            // 
            // cbx上级编码
            // 
            this.cbx上级编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx上级编码.FormattingEnabled = true;
            this.cbx上级编码.Location = new System.Drawing.Point(233, 7);
            this.cbx上级编码.Name = "cbx上级编码";
            this.cbx上级编码.Size = new System.Drawing.Size(101, 20);
            this.cbx上级编码.TabIndex = 1;
            this.cbx上级编码.SelectedIndexChanged += new System.EventHandler(this.cbx上级编码_SelectedIndexChanged);
            // 
            // cbx仓库编码
            // 
            this.cbx仓库编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx仓库编码.FormattingEnabled = true;
            this.cbx仓库编码.Location = new System.Drawing.Point(76, 7);
            this.cbx仓库编码.Name = "cbx仓库编码";
            this.cbx仓库编码.Size = new System.Drawing.Size(86, 20);
            this.cbx仓库编码.TabIndex = 0;
            this.cbx仓库编码.SelectedIndexChanged += new System.EventHandler(this.cbx仓库编码_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(171, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "所在货架：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "所在仓库：";
            // 
            // txt仓库名称
            // 
            this.txt仓库名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt仓库名称.ForeColor = System.Drawing.Color.Blue;
            this.txt仓库名称.Location = new System.Drawing.Point(414, 7);
            this.txt仓库名称.Name = "txt仓库名称";
            this.txt仓库名称.Size = new System.Drawing.Size(174, 21);
            this.txt仓库名称.TabIndex = 2;
            this.txt仓库名称.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt仓库名称_KeyDown);
            // 
            // lbl查询记录
            // 
            this.lbl查询记录.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl查询记录.AutoSize = true;
            this.lbl查询记录.Font = new System.Drawing.Font("宋体", 9F);
            this.lbl查询记录.ForeColor = System.Drawing.Color.Teal;
            this.lbl查询记录.Location = new System.Drawing.Point(785, 11);
            this.lbl查询记录.Name = "lbl查询记录";
            this.lbl查询记录.Size = new System.Drawing.Size(101, 12);
            this.lbl查询记录.TabIndex = 3;
            this.lbl查询记录.Text = "   共有999条记录";
            // 
            // btn查询
            // 
            this.btn查询.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn查询.Font = new System.Drawing.Font("宋体", 9F);
            this.btn查询.Location = new System.Drawing.Point(897, 3);
            this.btn查询.Name = "btn查询";
            this.btn查询.Size = new System.Drawing.Size(75, 28);
            this.btn查询.TabIndex = 3;
            this.btn查询.Text = "查询";
            this.btn查询.UseVisualStyleBackColor = false;
            this.btn查询.Click += new System.EventHandler(this.btn查询_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(341, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "储物箱名称：";
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
            this.label1.Size = new System.Drawing.Size(984, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "储物箱信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BAS_储物箱设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 539);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BAS_储物箱设置";
            this.Text = "M02_储物箱设置";
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt仓库名称;
        private System.Windows.Forms.Label lbl查询记录;
        private System.Windows.Forms.Button btn查询;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx仓库编码;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx上级编码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnBind;
    }
}
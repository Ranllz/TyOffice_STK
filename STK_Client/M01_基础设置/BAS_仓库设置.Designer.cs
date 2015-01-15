namespace STK_Client.M01_基础设置
{
    partial class BAS_仓库设置
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl查询记录 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGridView
            // 
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.Location = new System.Drawing.Point(0, 70);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.RowTemplate.Height = 23;
            this.dbGridView.Size = new System.Drawing.Size(871, 373);
            this.dbGridView.TabIndex = 6;
            this.dbGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbGridView_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnMod);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 30);
            this.panel1.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(794, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 3;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(871, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "仓库信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl查询记录
            // 
            this.lbl查询记录.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl查询记录.AutoSize = true;
            this.lbl查询记录.BackColor = System.Drawing.Color.LightBlue;
            this.lbl查询记录.Font = new System.Drawing.Font("宋体", 9F);
            this.lbl查询记录.ForeColor = System.Drawing.Color.Blue;
            this.lbl查询记录.Location = new System.Drawing.Point(756, 55);
            this.lbl查询记录.Name = "lbl查询记录";
            this.lbl查询记录.Size = new System.Drawing.Size(95, 12);
            this.lbl查询记录.TabIndex = 3;
            this.lbl查询记录.Text = "共有 999 条记录";
            // 
            // BAS_仓库设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 443);
            this.Controls.Add(this.lbl查询记录);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BAS_仓库设置";
            this.Text = "仓库设置";
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl查询记录;
    }
}
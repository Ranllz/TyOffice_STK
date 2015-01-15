namespace STK_Client.M03_期末管理
{
    partial class STK_期末结账
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STK_期末结账));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btn结账 = new System.Windows.Forms.Button();
            this.btn查询 = new System.Windows.Forms.Button();
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp年份 = new System.Windows.Forms.DateTimePicker();
            this.cbx仓库编码 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.LightBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(870, 40);
            this.lblTitle.TabIndex = 260;
            this.lblTitle.Text = "期末会计期间列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "stop_blue16.bmp");
            this.iglTree.Images.SetKeyName(2, "AddToFavorites.bmp");
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Font = new System.Drawing.Font("宋体", 9F);
            this.btnPrint.Location = new System.Drawing.Point(718, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 28);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClose.Location = new System.Drawing.Point(793, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnPrint);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btn结账);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(870, 30);
            this.pnlTop.TabIndex = 259;
            // 
            // btn结账
            // 
            this.btn结账.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn结账.Location = new System.Drawing.Point(0, 0);
            this.btn结账.Name = "btn结账";
            this.btn结账.Size = new System.Drawing.Size(100, 28);
            this.btn结账.TabIndex = 7;
            this.btn结账.Text = "开始结账(&S)";
            this.btn结账.UseVisualStyleBackColor = false;
            this.btn结账.Click += new System.EventHandler(this.btn结账_Click);
            // 
            // btn查询
            // 
            this.btn查询.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn查询.Location = new System.Drawing.Point(793, 0);
            this.btn查询.Name = "btn查询";
            this.btn查询.Size = new System.Drawing.Size(75, 28);
            this.btn查询.TabIndex = 14;
            this.btn查询.Text = "查询";
            this.btn查询.UseVisualStyleBackColor = false;
            this.btn查询.Click += new System.EventHandler(this.btn查询_Click);
            // 
            // dbGridView
            // 
            this.dbGridView.AllowUserToAddRows = false;
            this.dbGridView.AllowUserToDeleteRows = false;
            this.dbGridView.AllowUserToResizeRows = false;
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.EnableHeadersVisualStyles = false;
            this.dbGridView.Location = new System.Drawing.Point(2, 100);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dbGridView.RowHeadersWidth = 20;
            this.dbGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbGridView.RowTemplate.Height = 20;
            this.dbGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGridView.Size = new System.Drawing.Size(868, 408);
            this.dbGridView.TabIndex = 263;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 100);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 408);
            this.splitter1.TabIndex = 262;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtp年份);
            this.panel2.Controls.Add(this.btn查询);
            this.panel2.Controls.Add(this.cbx仓库编码);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 30);
            this.panel2.TabIndex = 264;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(221, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "查看年份：";
            // 
            // dtp年份
            // 
            this.dtp年份.CustomFormat = "yyyy年";
            this.dtp年份.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp年份.Location = new System.Drawing.Point(288, 4);
            this.dtp年份.Name = "dtp年份";
            this.dtp年份.ShowUpDown = true;
            this.dtp年份.Size = new System.Drawing.Size(63, 21);
            this.dtp年份.TabIndex = 16;
            this.dtp年份.ValueChanged += new System.EventHandler(this.dtp年份_ValueChanged);
            // 
            // cbx仓库编码
            // 
            this.cbx仓库编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx仓库编码.Font = new System.Drawing.Font("宋体", 9F);
            this.cbx仓库编码.FormattingEnabled = true;
            this.cbx仓库编码.Location = new System.Drawing.Point(76, 4);
            this.cbx仓库编码.Name = "cbx仓库编码";
            this.cbx仓库编码.Size = new System.Drawing.Size(130, 20);
            this.cbx仓库编码.TabIndex = 0;
            this.cbx仓库编码.SelectedIndexChanged += new System.EventHandler(this.cbx仓库编码_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "查看仓库：";
            // 
            // STK_期末结账
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTop);
            this.Name = "STK_期末结账";
            this.Text = "STK_期末结账";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btn结账;
        private System.Windows.Forms.Button btn查询;
        internal System.Windows.Forms.DataGridView dbGridView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbx仓库编码;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp年份;
        private System.Windows.Forms.Label label2;
    }
}
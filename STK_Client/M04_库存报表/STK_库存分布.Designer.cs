namespace STK_Client.M04_库存报表
{
    partial class STK_库存分布
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STK_库存分布));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.dbTreeView = new TY.Controls.DBTreeView();
            this.txt存货名称 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn刷新 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbx仓库编码 = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(859, 40);
            this.label1.TabIndex = 260;
            this.label1.Text = "库存存货数量查询";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "stop_blue16.bmp");
            this.iglTree.Images.SetKeyName(2, "AddToFavorites.bmp");
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
            this.dbTreeView.Size = new System.Drawing.Size(226, 472);
            this.dbTreeView.TabIndex = 249;
            this.dbTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dbTreeView_AfterSelect);
            // 
            // txt存货名称
            // 
            this.txt存货名称.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt存货名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt存货名称.ForeColor = System.Drawing.Color.Blue;
            this.txt存货名称.Location = new System.Drawing.Point(283, 4);
            this.txt存货名称.Name = "txt存货名称";
            this.txt存货名称.Size = new System.Drawing.Size(176, 21);
            this.txt存货名称.TabIndex = 17;
            this.txt存货名称.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt存货名称_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "查询存货：";
            // 
            // btn刷新
            // 
            this.btn刷新.BackColor = System.Drawing.SystemColors.Control;
            this.btn刷新.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn刷新.Location = new System.Drawing.Point(782, 0);
            this.btn刷新.Name = "btn刷新";
            this.btn刷新.Size = new System.Drawing.Size(75, 28);
            this.btn刷新.TabIndex = 14;
            this.btn刷新.Text = "刷新库存>>";
            this.btn刷新.UseVisualStyleBackColor = false;
            this.btn刷新.Click += new System.EventHandler(this.btn刷新_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dbTreeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 472);
            this.panel1.TabIndex = 261;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClose.Location = new System.Drawing.Point(782, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Font = new System.Drawing.Font("宋体", 9F);
            this.btnPrint.Location = new System.Drawing.Point(707, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 28);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnPrint);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(859, 30);
            this.pnlTop.TabIndex = 259;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 100);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 472);
            this.splitter1.TabIndex = 262;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt存货名称);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn刷新);
            this.panel2.Controls.Add(this.cbx仓库编码);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 30);
            this.panel2.TabIndex = 264;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "查询仓库：";
            // 
            // dbGridView
            // 
            this.dbGridView.AllowUserToAddRows = false;
            this.dbGridView.AllowUserToDeleteRows = false;
            this.dbGridView.AllowUserToResizeRows = false;
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dbGridView.ColumnHeadersHeight = 28;
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.EnableHeadersVisualStyles = false;
            this.dbGridView.Location = new System.Drawing.Point(228, 100);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dbGridView.RowHeadersWidth = 20;
            this.dbGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbGridView.RowTemplate.Height = 20;
            this.dbGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGridView.Size = new System.Drawing.Size(631, 472);
            this.dbGridView.TabIndex = 263;
            // 
            // STK_库存分布
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 572);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTop);
            this.Name = "STK_库存分布";
            this.Text = "STK_库存数量";
            this.panel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList iglTree;
        private TY.Controls.DBTreeView dbTreeView;
        private System.Windows.Forms.TextBox txt存货名称;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn刷新;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbx仓库编码;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DataGridView dbGridView;
    }
}
namespace STK_Client.M04_库存报表
{
    partial class STK_库存总账_明细
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl会计期间 = new System.Windows.Forms.Label();
            this.lbl存货名称 = new System.Windows.Forms.Label();
            this.lbl仓库名称 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(819, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "出库信息列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl会计期间);
            this.panel1.Controls.Add(this.lbl存货名称);
            this.panel1.Controls.Add(this.lbl仓库名称);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 42);
            this.panel1.TabIndex = 1;
            // 
            // lbl会计期间
            // 
            this.lbl会计期间.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl会计期间.AutoSize = true;
            this.lbl会计期间.ForeColor = System.Drawing.Color.Blue;
            this.lbl会计期间.Location = new System.Drawing.Point(699, 21);
            this.lbl会计期间.Name = "lbl会计期间";
            this.lbl会计期间.Size = new System.Drawing.Size(65, 12);
            this.lbl会计期间.TabIndex = 2;
            this.lbl会计期间.Text = "会计期间：";
            // 
            // lbl存货名称
            // 
            this.lbl存货名称.AutoSize = true;
            this.lbl存货名称.ForeColor = System.Drawing.Color.Blue;
            this.lbl存货名称.Location = new System.Drawing.Point(199, 21);
            this.lbl存货名称.Name = "lbl存货名称";
            this.lbl存货名称.Size = new System.Drawing.Size(95, 12);
            this.lbl存货名称.TabIndex = 0;
            this.lbl存货名称.Text = "仓库名称：588胶";
            // 
            // lbl仓库名称
            // 
            this.lbl仓库名称.AutoSize = true;
            this.lbl仓库名称.ForeColor = System.Drawing.Color.Blue;
            this.lbl仓库名称.Location = new System.Drawing.Point(19, 21);
            this.lbl仓库名称.Name = "lbl仓库名称";
            this.lbl仓库名称.Size = new System.Drawing.Size(89, 12);
            this.lbl仓库名称.TabIndex = 0;
            this.lbl仓库名称.Text = "查看仓库：仓库";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 40);
            this.panel2.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(359, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "返回(ESC)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dbGridView
            // 
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.Location = new System.Drawing.Point(0, 82);
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.RowTemplate.Height = 23;
            this.dbGridView.Size = new System.Drawing.Size(819, 448);
            this.dbGridView.TabIndex = 3;
            // 
            // STK_库存总账_明细
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 570);
            this.Controls.Add(this.dbGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "STK_库存总账_明细";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STK_账单管理_出入库";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.STK_账单管理_出入库_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl仓库名称;
        private System.Windows.Forms.Label lbl会计期间;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dbGridView;
        private System.Windows.Forms.Label lbl存货名称;
    }
}
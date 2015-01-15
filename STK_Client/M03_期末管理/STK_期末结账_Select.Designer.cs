namespace STK_Client.M03_期末管理
{
    partial class STK_期末结账_Select
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn选择 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx仓库编码 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl会计期间 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(14, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 1);
            this.label1.TabIndex = 0;
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btn取消.Location = new System.Drawing.Point(55, 135);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(100, 28);
            this.btn取消.TabIndex = 1;
            this.btn取消.Text = "取消(&C)";
            this.btn取消.UseVisualStyleBackColor = false;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn选择
            // 
            this.btn选择.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn选择.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btn选择.Location = new System.Drawing.Point(167, 135);
            this.btn选择.Name = "btn选择";
            this.btn选择.Size = new System.Drawing.Size(100, 28);
            this.btn选择.TabIndex = 1;
            this.btn选择.Text = "结账(&J)";
            this.btn选择.UseVisualStyleBackColor = false;
            this.btn选择.Click += new System.EventHandler(this.btn选择_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "结账仓库：";
            // 
            // cbx仓库编码
            // 
            this.cbx仓库编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx仓库编码.Font = new System.Drawing.Font("宋体", 12F);
            this.cbx仓库编码.ForeColor = System.Drawing.Color.Blue;
            this.cbx仓库编码.FormattingEnabled = true;
            this.cbx仓库编码.Location = new System.Drawing.Point(106, 73);
            this.cbx仓库编码.Name = "cbx仓库编码";
            this.cbx仓库编码.Size = new System.Drawing.Size(158, 24);
            this.cbx仓库编码.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "结账月份：";
            // 
            // lbl会计期间
            // 
            this.lbl会计期间.AutoSize = true;
            this.lbl会计期间.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl会计期间.ForeColor = System.Drawing.Color.Blue;
            this.lbl会计期间.Location = new System.Drawing.Point(106, 31);
            this.lbl会计期间.Name = "lbl会计期间";
            this.lbl会计期间.Size = new System.Drawing.Size(71, 16);
            this.lbl会计期间.TabIndex = 2;
            this.lbl会计期间.Text = "2015-01";
            // 
            // STK_期末结账_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 178);
            this.Controls.Add(this.lbl会计期间);
            this.Controls.Add(this.cbx仓库编码);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn选择);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "STK_期末结账_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAS_仓库设置_Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn选择;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx仓库编码;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl会计期间;
    }
}
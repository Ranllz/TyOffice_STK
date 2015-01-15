namespace STK_Client.M01_基础设置
{
    partial class BAS_储物箱设置_Editor
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txt备注 = new System.Windows.Forms.TextBox();
            this.txt仓库名称 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx仓库编码 = new System.Windows.Forms.ComboBox();
            this.cbx上级编码 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 2);
            this.label6.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnCancel.Location = new System.Drawing.Point(86, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnter.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnEnter.Location = new System.Drawing.Point(204, 184);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 28);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "保存(Ctrl+S)";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txt备注
            // 
            this.txt备注.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt备注.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt备注.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txt备注.ForeColor = System.Drawing.Color.Blue;
            this.txt备注.Location = new System.Drawing.Point(94, 101);
            this.txt备注.Multiline = true;
            this.txt备注.Name = "txt备注";
            this.txt备注.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt备注.Size = new System.Drawing.Size(266, 66);
            this.txt备注.TabIndex = 3;
            // 
            // txt仓库名称
            // 
            this.txt仓库名称.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt仓库名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt仓库名称.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txt仓库名称.ForeColor = System.Drawing.Color.Blue;
            this.txt仓库名称.Location = new System.Drawing.Point(94, 16);
            this.txt仓库名称.Name = "txt仓库名称";
            this.txt仓库名称.Size = new System.Drawing.Size(266, 23);
            this.txt仓库名称.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(51, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "备注：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "储物箱名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "所属仓库：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(23, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "所属货架：";
            // 
            // cbx仓库编码
            // 
            this.cbx仓库编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx仓库编码.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx仓库编码.FormattingEnabled = true;
            this.cbx仓库编码.Location = new System.Drawing.Point(94, 45);
            this.cbx仓库编码.Name = "cbx仓库编码";
            this.cbx仓库编码.Size = new System.Drawing.Size(266, 22);
            this.cbx仓库编码.TabIndex = 1;
            // 
            // cbx上级编码
            // 
            this.cbx上级编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx上级编码.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx上级编码.FormattingEnabled = true;
            this.cbx上级编码.Location = new System.Drawing.Point(94, 73);
            this.cbx上级编码.Name = "cbx上级编码";
            this.cbx上级编码.Size = new System.Drawing.Size(266, 22);
            this.cbx上级编码.TabIndex = 2;
            // 
            // BAS_储物箱设置_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 218);
            this.Controls.Add(this.cbx上级编码);
            this.Controls.Add(this.cbx仓库编码);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txt备注);
            this.Controls.Add(this.txt仓库名称);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BAS_储物箱设置_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M02_储物箱设置_Editor";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BAS_储物箱设置_Editor_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txt备注;
        private System.Windows.Forms.TextBox txt仓库名称;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx仓库编码;
        private System.Windows.Forms.ComboBox cbx上级编码;
    }
}
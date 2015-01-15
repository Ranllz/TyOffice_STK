namespace STK_Client.M01_基础设置
{
    partial class BAS_货架设置_Editor
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
            this.cbx上级编码 = new System.Windows.Forms.ComboBox();
            this.txt备注 = new System.Windows.Forms.TextBox();
            this.txt仓库名称 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt仓库地址 = new System.Windows.Forms.TextBox();
            this.btnOK_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 1);
            this.label6.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnCancel.Location = new System.Drawing.Point(51, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnter.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnEnter.Location = new System.Drawing.Point(295, 201);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(106, 28);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "保存(Ctrl+S)";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cbx上级编码
            // 
            this.cbx上级编码.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx上级编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx上级编码.Font = new System.Drawing.Font("宋体", 10.5F);
            this.cbx上级编码.ForeColor = System.Drawing.Color.Blue;
            this.cbx上级编码.FormattingEnabled = true;
            this.cbx上级编码.Location = new System.Drawing.Point(98, 49);
            this.cbx上级编码.Name = "cbx上级编码";
            this.cbx上级编码.Size = new System.Drawing.Size(331, 22);
            this.cbx上级编码.TabIndex = 1;
            // 
            // txt备注
            // 
            this.txt备注.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt备注.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt备注.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txt备注.ForeColor = System.Drawing.Color.Blue;
            this.txt备注.Location = new System.Drawing.Point(98, 106);
            this.txt备注.Multiline = true;
            this.txt备注.Name = "txt备注";
            this.txt备注.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt备注.Size = new System.Drawing.Size(331, 66);
            this.txt备注.TabIndex = 4;
            // 
            // txt仓库名称
            // 
            this.txt仓库名称.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt仓库名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt仓库名称.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txt仓库名称.ForeColor = System.Drawing.Color.Blue;
            this.txt仓库名称.Location = new System.Drawing.Point(98, 20);
            this.txt仓库名称.Name = "txt仓库名称";
            this.txt仓库名称.Size = new System.Drawing.Size(331, 23);
            this.txt仓库名称.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "所在仓库：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(53, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "备注：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "货架位置：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "货架名称：";
            // 
            // txt仓库地址
            // 
            this.txt仓库地址.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt仓库地址.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt仓库地址.Font = new System.Drawing.Font("宋体", 10.5F);
            this.txt仓库地址.ForeColor = System.Drawing.Color.Blue;
            this.txt仓库地址.Location = new System.Drawing.Point(98, 77);
            this.txt仓库地址.Name = "txt仓库地址";
            this.txt仓库地址.Size = new System.Drawing.Size(332, 23);
            this.txt仓库地址.TabIndex = 3;
            // 
            // btnOK_Add
            // 
            this.btnOK_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK_Add.Font = new System.Drawing.Font("宋体", 10.5F);
            this.btnOK_Add.Location = new System.Drawing.Point(173, 201);
            this.btnOK_Add.Name = "btnOK_Add";
            this.btnOK_Add.Size = new System.Drawing.Size(106, 28);
            this.btnOK_Add.TabIndex = 5;
            this.btnOK_Add.Text = "保存并新增(&A)";
            this.btnOK_Add.UseVisualStyleBackColor = false;
            this.btnOK_Add.Click += new System.EventHandler(this.btnOK_Add_Click);
            // 
            // BAS_货架设置_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 236);
            this.Controls.Add(this.txt仓库地址);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK_Add);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cbx上级编码);
            this.Controls.Add(this.txt备注);
            this.Controls.Add(this.txt仓库名称);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BAS_货架设置_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M02_货架设置_Editor";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BAS_货架设置_Editor_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cbx上级编码;
        private System.Windows.Forms.TextBox txt备注;
        private System.Windows.Forms.TextBox txt仓库名称;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt仓库地址;
        private System.Windows.Forms.Button btnOK_Add;
    }
}
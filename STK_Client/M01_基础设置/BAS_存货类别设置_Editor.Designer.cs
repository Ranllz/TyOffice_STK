namespace STK_Client.M01_基础设置
{
    partial class BAS_存货类别设置_Editor
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
            this.cbx类别状态 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK_Add = new System.Windows.Forms.Button();
            this.txt类别名称 = new System.Windows.Forms.TextBox();
            this.txt上级类别名称 = new System.Windows.Forms.TextBox();
            this.lblLBName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn存货类别 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx类别状态
            // 
            this.cbx类别状态.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx类别状态.FormattingEnabled = true;
            this.cbx类别状态.Location = new System.Drawing.Point(101, 82);
            this.cbx类别状态.Name = "cbx类别状态";
            this.cbx类别状态.Size = new System.Drawing.Size(150, 22);
            this.cbx类别状态.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(27, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 274;
            this.label11.Text = "类别状态：";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(14, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(413, 1);
            this.label9.TabIndex = 259;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(292, 131);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 31);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "保存(Ctrl+S)";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(37, 131);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK_Add
            // 
            this.btnOK_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK_Add.Location = new System.Drawing.Point(164, 131);
            this.btnOK_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK_Add.Name = "btnOK_Add";
            this.btnOK_Add.Size = new System.Drawing.Size(113, 31);
            this.btnOK_Add.TabIndex = 2;
            this.btnOK_Add.Text = "保存并新增(&A)";
            this.btnOK_Add.UseVisualStyleBackColor = false;
            this.btnOK_Add.Click += new System.EventHandler(this.btnOK_Add_Click);
            // 
            // txt类别名称
            // 
            this.txt类别名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt类别名称.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt类别名称.ForeColor = System.Drawing.Color.Blue;
            this.txt类别名称.Location = new System.Drawing.Point(101, 51);
            this.txt类别名称.Margin = new System.Windows.Forms.Padding(2);
            this.txt类别名称.Name = "txt类别名称";
            this.txt类别名称.Size = new System.Drawing.Size(313, 21);
            this.txt类别名称.TabIndex = 0;
            // 
            // txt上级类别名称
            // 
            this.txt上级类别名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt上级类别名称.Enabled = false;
            this.txt上级类别名称.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt上级类别名称.ForeColor = System.Drawing.SystemColors.Control;
            this.txt上级类别名称.Location = new System.Drawing.Point(101, 13);
            this.txt上级类别名称.Margin = new System.Windows.Forms.Padding(2);
            this.txt上级类别名称.Name = "txt上级类别名称";
            this.txt上级类别名称.ReadOnly = true;
            this.txt上级类别名称.Size = new System.Drawing.Size(289, 21);
            this.txt上级类别名称.TabIndex = 252;
            // 
            // lblLBName
            // 
            this.lblLBName.AutoSize = true;
            this.lblLBName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLBName.Location = new System.Drawing.Point(26, 57);
            this.lblLBName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLBName.Name = "lblLBName";
            this.lblLBName.Size = new System.Drawing.Size(65, 12);
            this.lblLBName.TabIndex = 258;
            this.lblLBName.Text = "类别名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 257;
            this.label1.Text = "上级类别：";
            // 
            // btn存货类别
            // 
            this.btn存货类别.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn存货类别.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn存货类别.Location = new System.Drawing.Point(391, 13);
            this.btn存货类别.Name = "btn存货类别";
            this.btn存货类别.Size = new System.Drawing.Size(24, 24);
            this.btn存货类别.TabIndex = 5;
            this.btn存货类别.Text = "…";
            this.btn存货类别.UseVisualStyleBackColor = true;
            this.btn存货类别.Click += new System.EventHandler(this.btn存货类别_Click);
            // 
            // BAS_存货类别设置_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 170);
            this.Controls.Add(this.btn存货类别);
            this.Controls.Add(this.cbx类别状态);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK_Add);
            this.Controls.Add(this.txt类别名称);
            this.Controls.Add(this.txt上级类别名称);
            this.Controls.Add(this.lblLBName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "BAS_存货类别设置_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "M02_存货类型设置_Editor";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BAS_存货类别设置_Editor_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx类别状态;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK_Add;
        private System.Windows.Forms.TextBox txt类别名称;
        private System.Windows.Forms.TextBox txt上级类别名称;
        private System.Windows.Forms.Label lblLBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn存货类别;
    }
}
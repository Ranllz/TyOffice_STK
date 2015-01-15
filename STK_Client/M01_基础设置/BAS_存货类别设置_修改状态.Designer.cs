namespace STK_Client.M01_基础设置
{
    partial class BAS_存货类别设置_修改状态
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
            this.chk包含下级 = new System.Windows.Forms.CheckBox();
            this.txt类别名称 = new System.Windows.Forms.TextBox();
            this.lblLBName = new System.Windows.Forms.Label();
            this.cbx类别状态 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk包含下级
            // 
            this.chk包含下级.AutoSize = true;
            this.chk包含下级.Checked = true;
            this.chk包含下级.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk包含下级.Location = new System.Drawing.Point(90, 117);
            this.chk包含下级.Name = "chk包含下级";
            this.chk包含下级.Size = new System.Drawing.Size(166, 18);
            this.chk包含下级.TabIndex = 309;
            this.chk包含下级.Text = "同时更新下级类别状态";
            this.chk包含下级.UseVisualStyleBackColor = true;
            // 
            // txt类别名称
            // 
            this.txt类别名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt类别名称.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt类别名称.ForeColor = System.Drawing.Color.Blue;
            this.txt类别名称.Location = new System.Drawing.Point(90, 31);
            this.txt类别名称.Margin = new System.Windows.Forms.Padding(2);
            this.txt类别名称.Name = "txt类别名称";
            this.txt类别名称.ReadOnly = true;
            this.txt类别名称.Size = new System.Drawing.Size(219, 21);
            this.txt类别名称.TabIndex = 307;
            // 
            // lblLBName
            // 
            this.lblLBName.AutoSize = true;
            this.lblLBName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLBName.Location = new System.Drawing.Point(17, 36);
            this.lblLBName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLBName.Name = "lblLBName";
            this.lblLBName.Size = new System.Drawing.Size(65, 12);
            this.lblLBName.TabIndex = 308;
            this.lblLBName.Text = "类别名称：";
            // 
            // cbx类别状态
            // 
            this.cbx类别状态.BackColor = System.Drawing.SystemColors.Window;
            this.cbx类别状态.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx类别状态.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbx类别状态.ForeColor = System.Drawing.Color.Blue;
            this.cbx类别状态.FormattingEnabled = true;
            this.cbx类别状态.Location = new System.Drawing.Point(90, 75);
            this.cbx类别状态.Name = "cbx类别状态";
            this.cbx类别状态.Size = new System.Drawing.Size(219, 20);
            this.cbx类别状态.TabIndex = 305;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(17, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 306;
            this.label12.Text = "类别状态：";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 2);
            this.label2.TabIndex = 304;
            this.label2.Text = "label2";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(65, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 33);
            this.btnCancel.TabIndex = 303;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(181, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 33);
            this.btnOK.TabIndex = 302;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // BAS_存货类别设置_修改状态
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 208);
            this.Controls.Add(this.chk包含下级);
            this.Controls.Add(this.txt类别名称);
            this.Controls.Add(this.lblLBName);
            this.Controls.Add(this.cbx类别状态);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BAS_存货类别设置_修改状态";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M02_存货类别_修改状态";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk包含下级;
        private System.Windows.Forms.TextBox txt类别名称;
        private System.Windows.Forms.Label lblLBName;
        private System.Windows.Forms.ComboBox cbx类别状态;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
namespace STK_Client.Main
{
    partial class Man_UserPswd
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt用户名称 = new System.Windows.Forms.TextBox();
            this.txt当前密码 = new System.Windows.Forms.TextBox();
            this.txt新设密码 = new System.Windows.Forms.TextBox();
            this.txt确认密码 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "当前密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "新设密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码：";
            // 
            // txt用户名称
            // 
            this.txt用户名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt用户名称.Location = new System.Drawing.Point(94, 22);
            this.txt用户名称.Name = "txt用户名称";
            this.txt用户名称.ReadOnly = true;
            this.txt用户名称.Size = new System.Drawing.Size(181, 21);
            this.txt用户名称.TabIndex = 4;
            // 
            // txt当前密码
            // 
            this.txt当前密码.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt当前密码.ForeColor = System.Drawing.Color.Blue;
            this.txt当前密码.Location = new System.Drawing.Point(94, 60);
            this.txt当前密码.Name = "txt当前密码";
            this.txt当前密码.PasswordChar = '*';
            this.txt当前密码.Size = new System.Drawing.Size(181, 21);
            this.txt当前密码.TabIndex = 5;
            // 
            // txt新设密码
            // 
            this.txt新设密码.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt新设密码.ForeColor = System.Drawing.Color.Blue;
            this.txt新设密码.Location = new System.Drawing.Point(94, 98);
            this.txt新设密码.Name = "txt新设密码";
            this.txt新设密码.PasswordChar = '*';
            this.txt新设密码.Size = new System.Drawing.Size(181, 21);
            this.txt新设密码.TabIndex = 6;
            // 
            // txt确认密码
            // 
            this.txt确认密码.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt确认密码.ForeColor = System.Drawing.Color.Blue;
            this.txt确认密码.Location = new System.Drawing.Point(94, 136);
            this.txt确认密码.Name = "txt确认密码";
            this.txt确认密码.PasswordChar = '*';
            this.txt确认密码.Size = new System.Drawing.Size(181, 21);
            this.txt确认密码.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(10, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 2);
            this.label5.TabIndex = 65;
            this.label5.Text = "label5";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(61, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 26);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(175, 185);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 26);
            this.btnOK.TabIndex = 63;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Man_UserPswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(312, 221);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txt确认密码);
            this.Controls.Add(this.txt新设密码);
            this.Controls.Add(this.txt当前密码);
            this.Controls.Add(this.txt用户名称);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Man_UserPswd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Man_UserPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt用户名称;
        private System.Windows.Forms.TextBox txt当前密码;
        private System.Windows.Forms.TextBox txt新设密码;
        private System.Windows.Forms.TextBox txt确认密码;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
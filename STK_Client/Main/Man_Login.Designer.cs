namespace STK_Client
{
    partial class Man_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_Login));
            this.lblUserCode = new System.Windows.Forms.Label();
            this.lblUserPswd = new System.Windows.Forms.Label();
            this.txtLoginPswd = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpLoginDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserCode.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserCode.Location = new System.Drawing.Point(186, 121);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(72, 13);
            this.lblUserCode.TabIndex = 0;
            this.lblUserCode.Text = "用户账号：";
            // 
            // lblUserPswd
            // 
            this.lblUserPswd.AutoSize = true;
            this.lblUserPswd.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserPswd.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserPswd.Location = new System.Drawing.Point(186, 160);
            this.lblUserPswd.Name = "lblUserPswd";
            this.lblUserPswd.Size = new System.Drawing.Size(72, 13);
            this.lblUserPswd.TabIndex = 1;
            this.lblUserPswd.Text = "用户密码：";
            // 
            // txtLoginPswd
            // 
            this.txtLoginPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPswd.ForeColor = System.Drawing.Color.Blue;
            this.txtLoginPswd.Location = new System.Drawing.Point(260, 155);
            this.txtLoginPswd.Name = "txtLoginPswd";
            this.txtLoginPswd.PasswordChar = '*';
            this.txtLoginPswd.Size = new System.Drawing.Size(150, 21);
            this.txtLoginPswd.TabIndex = 1;
            this.txtLoginPswd.UseSystemPasswordChar = true;
            this.txtLoginPswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginPswd_KeyPress);
            // 
            // txtLoginName
            // 
            this.txtLoginName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginName.ForeColor = System.Drawing.Color.Blue;
            this.txtLoginName.Location = new System.Drawing.Point(260, 117);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(150, 21);
            this.txtLoginName.TabIndex = 0;
            this.txtLoginName.Text = "管理员";
            this.txtLoginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginName_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(207, 245);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(316, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出(&X)";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.BackColor = System.Drawing.SystemColors.Control;
            this.chkRemember.Location = new System.Drawing.Point(297, 190);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(120, 16);
            this.chkRemember.TabIndex = 2;
            this.chkRemember.Text = "记住我的登录密码";
            this.chkRemember.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(10, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 2);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(103, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 10;
            this.label1.Tag = "";
            this.label1.Text = "恒光物资管理系统";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(186, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "业务日期：";
            // 
            // dtpLoginDate
            // 
            this.dtpLoginDate.CustomFormat = "yyyy年MM月dd日";
            this.dtpLoginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoginDate.Location = new System.Drawing.Point(259, 77);
            this.dtpLoginDate.Name = "dtpLoginDate";
            this.dtpLoginDate.Size = new System.Drawing.Size(151, 21);
            this.dtpLoginDate.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "GLG.SOFT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Man_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(450, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpLoginDate);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.txtLoginPswd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUserPswd);
            this.Controls.Add(this.lblUserCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Man_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.TfmMan_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.Label lblUserPswd;
        private System.Windows.Forms.TextBox txtLoginPswd;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpLoginDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
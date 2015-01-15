namespace STK_Client.M04_库存报表
{
    partial class STK_库存账_Query
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
            this.btnSelectGoods = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx仓库编码 = new System.Windows.Forms.ComboBox();
            this.txtFindGoods = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chk仅显业务 = new System.Windows.Forms.CheckBox();
            this.dtp结束日期 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始日期 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectGoods
            // 
            this.btnSelectGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectGoods.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectGoods.ForeColor = System.Drawing.Color.Black;
            this.btnSelectGoods.Location = new System.Drawing.Point(395, 58);
            this.btnSelectGoods.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectGoods.Name = "btnSelectGoods";
            this.btnSelectGoods.Size = new System.Drawing.Size(23, 18);
            this.btnSelectGoods.TabIndex = 127;
            this.btnSelectGoods.Text = "…";
            this.btnSelectGoods.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(39, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 2);
            this.label4.TabIndex = 126;
            // 
            // cbx仓库编码
            // 
            this.cbx仓库编码.BackColor = System.Drawing.SystemColors.Control;
            this.cbx仓库编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx仓库编码.ForeColor = System.Drawing.Color.Blue;
            this.cbx仓库编码.FormattingEnabled = true;
            this.cbx仓库编码.Location = new System.Drawing.Point(118, 98);
            this.cbx仓库编码.Margin = new System.Windows.Forms.Padding(2);
            this.cbx仓库编码.Name = "cbx仓库编码";
            this.cbx仓库编码.Size = new System.Drawing.Size(265, 20);
            this.cbx仓库编码.TabIndex = 125;
            // 
            // txtFindGoods
            // 
            this.txtFindGoods.BackColor = System.Drawing.SystemColors.Window;
            this.txtFindGoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindGoods.ForeColor = System.Drawing.Color.Blue;
            this.txtFindGoods.Location = new System.Drawing.Point(118, 57);
            this.txtFindGoods.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindGoods.Name = "txtFindGoods";
            this.txtFindGoods.Size = new System.Drawing.Size(265, 21);
            this.txtFindGoods.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 123;
            this.label3.Text = "查询仓库：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 122;
            this.label2.Text = "查询商品：";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(114, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 27);
            this.btnCancel.TabIndex = 120;
            this.btnCancel.Text = "取消(&N)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(242, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 27);
            this.btnOK.TabIndex = 119;
            this.btnOK.Text = "确定(&Y)";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // chk仅显业务
            // 
            this.chk仅显业务.AutoSize = true;
            this.chk仅显业务.Checked = true;
            this.chk仅显业务.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk仅显业务.Location = new System.Drawing.Point(118, 172);
            this.chk仅显业务.Name = "chk仅显业务";
            this.chk仅显业务.Size = new System.Drawing.Size(132, 16);
            this.chk仅显业务.TabIndex = 118;
            this.chk仅显业务.Text = "只显示有业务的商品";
            this.chk仅显业务.UseVisualStyleBackColor = true;
            // 
            // dtp结束日期
            // 
            this.dtp结束日期.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束日期.Location = new System.Drawing.Point(261, 135);
            this.dtp结束日期.Name = "dtp结束日期";
            this.dtp结束日期.Size = new System.Drawing.Size(122, 21);
            this.dtp结束日期.TabIndex = 117;
            // 
            // dtp开始日期
            // 
            this.dtp开始日期.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始日期.Location = new System.Drawing.Point(118, 135);
            this.dtp开始日期.Name = "dtp开始日期";
            this.dtp开始日期.Size = new System.Drawing.Size(122, 21);
            this.dtp开始日期.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "业务日期从                      至";
            // 
            // STK_库存账_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 298);
            this.Controls.Add(this.btnSelectGoods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx仓库编码);
            this.Controls.Add(this.txtFindGoods);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chk仅显业务);
            this.Controls.Add(this.dtp结束日期);
            this.Controls.Add(this.dtp开始日期);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "STK_库存账_Query";
            this.Text = "STK_库存账_Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectGoods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx仓库编码;
        private System.Windows.Forms.TextBox txtFindGoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.CheckBox chk仅显业务;
        public System.Windows.Forms.DateTimePicker dtp结束日期;
        public System.Windows.Forms.DateTimePicker dtp开始日期;
        private System.Windows.Forms.Label label1;

    }
}
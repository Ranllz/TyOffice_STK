using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace STK_Client.M02_库存管理
{
    public partial class STK_库存入库_SetCnt : Form
    {
        public decimal Value = 0;
        //
        public STK_库存入库_SetCnt()
        {
            InitializeComponent();
            //
            this.Text = "设置数量";
            this.nud数量.Select(0, this.nud数量.Text.Length);
        }

        private void nud数量_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnEnter.PerformClick();
            }
        }

        private void STK_库存入库_SetCnt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.btnCancel.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnEnter.PerformClick();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Value = this.nud数量.Value.ToDecimalDef();
            //
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

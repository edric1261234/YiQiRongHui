using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class JinXiangCaiJi : Form
    {
        public JinXiangCaiJi()
        {
            InitializeComponent();
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            txt_koushui.Text = txt_total.Text;
        }

        private void btn_suode_Click(object sender, EventArgs e)
        {
            SuoDeShui f = new SuoDeShui();
            f.ShowDialog();
        }

        private void btn_zengzhi_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
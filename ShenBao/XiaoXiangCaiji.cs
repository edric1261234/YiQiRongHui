using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class XiaoXiangCaiji : Form
    {
        public XiaoXiangCaiji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XiaoXiangDetail f = new XiaoXiangDetail();
            f.ShowDialog();
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
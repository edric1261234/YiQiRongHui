using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class ZengZhiShui : Form
    {
        public ZengZhiShui()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShenBaoBiaoTianXie f = new ShenBaoBiaoTianXie();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShenBaoBiaoFaSong f = new ShenBaoBiaoFaSong();
            f.Show();
        }

        private void btn_shenbaochaxun_Click(object sender, EventArgs e)
        {
            ShenBaoChaXun f = new ShenBaoChaXun();
            f.Show();
        }

        private void btn_jiaofei_Click(object sender, EventArgs e)
        {
            WangShangJiaoFei f = new WangShangJiaoFei();
            f.Show();
        }

        private void btn_suode_Click(object sender, EventArgs e)
        {
            SuoDeShui f = new SuoDeShui();
            f.Show();
        }

        private void btn_zengzhi_Click(object sender, EventArgs e)
        {
            ZengZhiShui f = new ZengZhiShui();
            f.ShowDialog();
        }
    }
}
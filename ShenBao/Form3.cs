using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShenBaoBiaoTianXie f = new ShenBaoBiaoTianXie();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShenBaoBiaoFaSong f = new ShenBaoBiaoFaSong();
            f.ShowDialog();
        }

        private void btn_shenbaochaxun_Click(object sender, EventArgs e)
        {
            ShenBaoChaXun f = new ShenBaoChaXun();
            f.ShowDialog();
        }

        private void btn_jiaofei_Click(object sender, EventArgs e)
        {
            WangShangJiaoFei f = new WangShangJiaoFei();
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
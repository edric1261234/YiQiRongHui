using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JinXiangCaiJi f = new JinXiangCaiJi();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XiaoXiangCaiji f = new XiaoXiangCaiji();
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
            //Form2.zengzhishui.Show();
        }
    }
}
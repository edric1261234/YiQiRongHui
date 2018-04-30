using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class WangShangJiaoFei : Form
    {
        public WangShangJiaoFei()
        {
            InitializeComponent();
            ExcelOperator excel = new ExcelOperator();
            string t = excel.getValue("主表", "S37");

            _txt_shuie.Text = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("扣税成功");
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
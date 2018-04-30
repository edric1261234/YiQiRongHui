using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class ShenBaoBiaoTianXie : Form
    {
        public ShenBaoBiaoTianXie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelOperator excel = new ExcelOperator();
            excel.ShowExcel();
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class SDS_SBBTX : Form
    {
        public SDS_SBBTX()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelOperator excel = new ExcelOperator();
            excel.openExcel("yuebao");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelOperator excel = new ExcelOperator();
            excel.openExcel("jibao");
        }
    }
}
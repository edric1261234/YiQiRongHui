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

            INIClass ini_class = new INIClass("D:\\yinuo.ini");
            string shuier = ini_class.IniReadValue("KaiPiao", "ShuiEr");
            _txt_shuie.Text = shuier;
            _btn_jine.Text = ini_class.IniReadValue("KaiPiao", "HeJi"); //(Double.Parse(shuier) / 0.17).ToString("f2");
            _txt_total_jiner.Text = _btn_jine.Text;
            _txt_total_shuier.Text = _txt_shuie.Text;
            ini_class.IniWriteValue("XiaoXiangCaiJi", "ZongShuiE", _btn_jine.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XiaoXiangDetail f = new XiaoXiangDetail();
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

        private void XiaoXiangCaiji_Load(object sender, EventArgs e)
        {

        }


        private void _btn_jine_Click(object sender, EventArgs e)
        {
            Import f = new Import();
            f.Show();
        }
    }
}
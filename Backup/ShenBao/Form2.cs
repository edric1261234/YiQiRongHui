using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class Form2 : Form
    {
        public static ZengZhiShui zengzhishui = null;
        public Form2()
        {
            InitializeComponent();
            zengzhishui = new ZengZhiShui();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZengZhiShui f = new ZengZhiShui();
            f.ShowDialog();
            //zengzhishui.Show();
        }

        private void btn_suode_Click(object sender, EventArgs e)
        {
            SuoDeShui f = new SuoDeShui();
            f.Show();
        }
    }
}
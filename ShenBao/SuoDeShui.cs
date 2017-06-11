using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class SuoDeShui : Form
    {
        public SuoDeShui()
        {
            InitializeComponent();
        }

        private void btn_sbbtx_Click(object sender, EventArgs e)
        {
            SDS_SBBTX f = new SDS_SBBTX();
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

        private void btn_wssb_Click(object sender, EventArgs e)
        {
            SDS_WSSB f = new SDS_WSSB();
            f.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class SDS_WSSB : Form
    {
        public SDS_WSSB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���ͳɹ�");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��˰�ɹ�");
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
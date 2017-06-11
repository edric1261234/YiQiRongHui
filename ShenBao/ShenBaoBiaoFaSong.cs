using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class ShenBaoBiaoFaSong : Form
    {
        public ShenBaoBiaoFaSong()
        {
            InitializeComponent();

            DataGridViewRowCollection rows = dataGridView1.Rows;
            rows.Add(new Object[] { "", "增值税一般纳税人申报", 0, 0, 0, "", "增值税申报" });
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("发送成功");
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
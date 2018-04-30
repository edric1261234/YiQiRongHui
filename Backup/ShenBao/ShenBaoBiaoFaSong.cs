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
            ExcelOperator excel = new ExcelOperator();
            string val = excel.getValue("����", "S43");
            /*string val = "0";
            try
            {
                val = (double.Parse(excel.getValue("����һ", "F8")) - double.Parse(excel.getValue("�����", "G8"))).ToString();
            }
            catch (Exception ex)
            { 
            }*/

            
            rows.Add(new Object[] { "", "��ֵ˰һ����˰���걨", 0, val, 0, "", "��ֵ˰�걨" });
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���ͳɹ�");
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
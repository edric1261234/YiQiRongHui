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
            string val = excel.getValue("主表", "S43");
            /*string val = "0";
            try
            {
                val = (double.Parse(excel.getValue("附表一", "F8")) - double.Parse(excel.getValue("附表二", "G8"))).ToString();
            }
            catch (Exception ex)
            { 
            }*/

            
            rows.Add(new Object[] { "", "增值税一般纳税人申报", 0, val, 0, "", "增值税申报" });
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("发送成功");
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
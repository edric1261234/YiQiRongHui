using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Reflection;

namespace ShenBao
{
    class ExcelOperator
    {
        string root = @"D:\";

        string shenbaobiao_path;

        public ExcelOperator()
        {
            root = System.AppDomain.CurrentDomain.BaseDirectory;
            
            shenbaobiao_path = root + "shenbaobiao.xls";
        }

        public void ShowExcel()
        {
            
            INIClass ini_class = new INIClass("D:\\yinuo.ini");

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.DisplayAlerts = false;//����ʾ��ʾ�Ի���  

            Microsoft.Office.Interop.Excel.Workbook xBook = excel.Workbooks._Open(shenbaobiao_path,
            Missing.Value, Missing.Value, Missing.Value, Missing.Value
            , Missing.Value, Missing.Value, Missing.Value, Missing.Value
            , Missing.Value, Missing.Value, Missing.Value, Missing.Value);


            string G8 = ini_class.IniReadValue("JiXiangCaiJi", "ZongShuiE");
            if (G8 != "")
            {
                Microsoft.Office.Interop.Excel.Worksheet xSheet = (Microsoft.Office.Interop.Excel.Worksheet)xBook.Sheets["�����"];
                Microsoft.Office.Interop.Excel.Range rng = xSheet.get_Range("G8", Missing.Value);
                rng.Value2 = G8;
            }
           

            string E8 = ini_class.IniReadValue("XiaoXiangCaiJi", "ZongShuiE");
            if (E8 != "")
            {
                Microsoft.Office.Interop.Excel.Worksheet xSheet = (Microsoft.Office.Interop.Excel.Worksheet)xBook.Sheets["����һ"];
                Microsoft.Office.Interop.Excel.Range rng = xSheet.get_Range("E8", Missing.Value);
                rng.Value2 = E8;
            }

            
            ////���淽ʽ��
            xBook.Save();
            excel.Visible = true;

            //xSheet = null;
            //xBook = null;
            //excel.Quit();//Excel�ă������˳�
            //excel = null;
        }

        public string getValue(string sheet_name, string cell_ame)
        {
            //try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.DisplayAlerts = false;//����ʾ��ʾ�Ի���  

                Microsoft.Office.Interop.Excel.Workbook xBook = excel.Workbooks._Open(shenbaobiao_path,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value
                , Missing.Value, Missing.Value, Missing.Value, Missing.Value
                , Missing.Value, Missing.Value, Missing.Value, Missing.Value);

                Microsoft.Office.Interop.Excel.Worksheet xSheet = (Microsoft.Office.Interop.Excel.Worksheet)xBook.Sheets[sheet_name];
                Microsoft.Office.Interop.Excel.Range rng = xSheet.get_Range(cell_ame, Missing.Value);

                string val = rng.Value2.ToString();
                xSheet = null;
                xBook = null;
                excel.Quit();//Excel�ă������˳�
                excel = null;

                return val;
            }
            //catch (Exception e) {
            //    return "0";
            //}
           
        }

        public void openExcel(string excel_name)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.DisplayAlerts = false;//����ʾ��ʾ�Ի���  

            Microsoft.Office.Interop.Excel.Workbook xBook = excel.Workbooks._Open(root + excel_name,
            Missing.Value, Missing.Value, Missing.Value, Missing.Value
            , Missing.Value, Missing.Value, Missing.Value, Missing.Value
            , Missing.Value, Missing.Value, Missing.Value, Missing.Value);

            excel.Visible = true;

           // xBook = null;
           // excel.Quit();//Excel�ă������˳�
           // excel = null;
        }
    }

   

}

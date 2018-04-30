using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShenBao
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void _btn_import_Click(object sender, EventArgs e)
        {
            _btn_import_xml.Visible = true;
        }

        private void _btn_import_xml_Click(object sender, EventArgs e)
        {

        }
    }
}
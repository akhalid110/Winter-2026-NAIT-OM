using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Calculate_Btn_Click(object sender, EventArgs e)
        {
            int.TryParse(UI_Value1_Tbx.Text,out int v1);
            int.TryParse(UI_Value2_Tbx.Text,out int v2);
            int v3 = v1 + v2;
            UI_Sum_Tbx.Text = v3.ToString() ; 
        }
    }
}

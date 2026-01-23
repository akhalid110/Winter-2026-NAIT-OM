using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Change_Btn_Click(object sender, EventArgs e)
        {
            // UI_Display_Lbl.Text = "Hello World";  Lecture2B demo1
            UI_Display_Lbl.Text = UI_Input_Tbx.Text;  //Lecture2B demo2
            UI_Input_Tbx.Clear();

        }
    }
}

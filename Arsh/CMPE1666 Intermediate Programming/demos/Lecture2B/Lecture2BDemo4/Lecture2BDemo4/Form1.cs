using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Input_Tbx_TextChanged(object sender, EventArgs e)
        {
            UI_Display_Tbx.Text = UI_Input_Tbx.Text;
        }
    }
}

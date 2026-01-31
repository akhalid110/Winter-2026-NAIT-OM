using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3Demo3
{
    public partial class Form1 : Form
    {
        List<int> _values =new List<int> {50, 26,28, 49, 72, 13, 15, 92, 17, 43, 18, 33, 12, 30, 25};
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_Display_Btn_Click(object sender, EventArgs e)
        {
            UI_Display_Tbx.Text = string.Join(" , ", _values);
        }
    }
}

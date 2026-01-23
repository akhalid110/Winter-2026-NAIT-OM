using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo6
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
            count = 0;
            
        }

        private void UI_Timer_Tick(object sender, EventArgs e)
        {
            this.Text = $"Count is: {count}";
            count++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2Exercise1
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            count++;
            Text = $"This form has been double-clicked {count} times";
        }
    }
}

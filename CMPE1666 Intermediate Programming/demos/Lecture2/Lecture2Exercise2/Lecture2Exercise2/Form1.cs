using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2Exercise2
{
    public partial class Form1 : Form
    {
        int count = 0;
        int toggle = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ++count;
            if(toggle == 0)
            {
                this.Text = "This is the nice form";
                toggle = 1;
            }
            else
            {
                this.Text = $"The mouse has been clicked {count} times";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2Demo2
{
    public partial class Form1 : Form
    {
        //Member Variables for the form
        string myString = "This is my first form.";
        public Form1()
        {
            InitializeComponent();
            Text = myString;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Text = "The mouse has been double-clicked";
            BackColor = Color.Red;
        }
    }
}

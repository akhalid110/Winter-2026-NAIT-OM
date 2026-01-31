using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo6
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        int count;
        public Form1()
        {
            InitializeComponent();
            sw.Start();
            count = 0;
        }

        //demo6 and Demo6B
        private void UI_Timer_Tick(object sender, EventArgs e)  
        {
            this.Text = $"Count is: {count} and number of milliseconds Elapsed: {sw.ElapsedMilliseconds}";  
             count++;
            int x = count;
            if(x % 20 == 0) //Demo6C
            {
                UI_Display_Lbx.Items.Add($"The value of Count: {x}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }
    }
}

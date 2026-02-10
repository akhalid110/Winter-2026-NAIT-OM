using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lecture4Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_LoadFile1_Btn_Click(object sender, EventArgs e)
        {
            string[] lines1=File.ReadAllLines("../../../../file1.txt");
            UI_DisplayFile1_Lbx.Items.Clear();
            foreach (string line in lines1)
            {
                UI_DisplayFile1_Lbx.Items.Add(line);
            }
        }

        private void UI_LoadFile2_Btn_Click(object sender, EventArgs e)
        {
            string[] lines2 = File.ReadAllLines("../../../../file2.txt");
            UI_DisplayFile2_Tbx.Text = string.Join(" ",lines2);

        }
    }
}

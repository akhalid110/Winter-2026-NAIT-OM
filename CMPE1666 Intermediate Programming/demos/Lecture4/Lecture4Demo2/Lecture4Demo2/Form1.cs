using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture4Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_SaveToFile_Btn_Click(object sender, EventArgs e)
        {
            string data = UI_ValuesFromUser_Tbx.Text;
            File.WriteAllText("../../../../file2.txt", data);
            MessageBox.Show("File has been saved. ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3Demo2
{
    public partial class Form1 : Form
    {
        List<string> myData = new List<string>();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            UI_AddToList_btn.Enabled = true;
            UI_SendToListBox_btn.Enabled = false;
        }

        private void UI_AddToList_btn_Click(object sender, EventArgs e)
        {
            myData.Add(UI_NewValue_Tbx.Text);
            UI_NewValue_Tbx.Clear();
            count++;
            UI_Count_Tbx.Text = count.ToString();
            if (count > 10)
            {
                UI_AddToList_btn.Enabled = false;
                UI_SendToListBox_btn.Enabled = true;
            }
        }

        private void UI_SendToListBox_btn_Click(object sender, EventArgs e)
        {
            foreach(string s in myData)
            {
                UI_ValuesList_Lbx.Items.Add(s);
            }
        }
    }
}

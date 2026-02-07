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

namespace Lecture4Demo1
{
    public partial class Form1 : Form
    {
        List<string> textList = new List<string>();
        public Form1()
        {
            InitializeComponent();

            UI_AddToList_Btn.Enabled = true;
            UI_Save_Btn.Enabled = false;
        }

        private void UI_AddToList_Btn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(UI_Input_Tbx.Text))
            {
                textList.Add(UI_Input_Tbx.Text);     //Added to list
                UI_Display_Lbx.Items.Add(UI_Input_Tbx.Text); // Added to ListBox
                UI_Input_Tbx.Clear();  //textbox -> clear

                if(textList.Count == 10)
                {
                    UI_AddToList_Btn.Enabled = false;
                    UI_Save_Btn.Enabled = true;
                }
            }
        }

        private void UI_Save_Btn_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("../../../../file1.txt", textList);
            MessageBox.Show("File has been saved.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UI_Enrolled_Cbx.CheckedChanged += UI_Enrolled_Cbx_CheckedChanged;
        }

        private void UI_Enrolled_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            string name = UI_Name_Tbx.Text.Trim();
            string course = UI_Course_Tbx.Text.Trim();
            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Please enter both Name and Course");
                return;
            }



            if (UI_Enrolled_Cbx.Checked)
            {
                UI_Output_Lbl.Text = $"{name} enrolled for {course}";
            }
            else if(UI_Enrolled_Cbx.Checked == false)
            {
                UI_Output_Lbl.Text = $"{name} not enrolled for course";
            }
        }
    }
}

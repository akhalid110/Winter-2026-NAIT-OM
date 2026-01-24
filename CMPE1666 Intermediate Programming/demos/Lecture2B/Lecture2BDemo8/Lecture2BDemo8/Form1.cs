using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_ClickMe_Btn_Click(object sender, EventArgs e)
        {
            string Color = "";
            string EngineCapacity = "";

            if (UI_Red_Rdb.Checked)
                Color = "Red";
            if (UI_Blue_Rdb.Checked)
                Color = "Blue";
            if (UI_Green_Rdb.Checked)
                Color = "Green";

            if (UI_1500_Rdb.Checked)
                EngineCapacity = "1500";
            if (UI_2000_Rdb.Checked)
                EngineCapacity = "2000";
            if (UI_2500_Rdb.Checked)
                EngineCapacity = "2500";
            MessageBox.Show($"you wish to have a car with Color {Color} and Engine Capacity {EngineCapacity} ");
        }
    }
}

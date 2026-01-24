using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2BDemo7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal CalculateTotalCost(string item1Cost, string item2Cost, bool b)
        {
            decimal cost1 = 0;
            decimal cost2 = 0;

            decimal.TryParse(item1Cost, out cost1);
            decimal.TryParse(item2Cost, out cost2);

            decimal total = cost1 + cost2;
            if (b)
            {
                total += total * 0.05m;
            }
            return total;


        }

        private void UI_TotalCost_Btn_Click(object sender, EventArgs e)
        {
            decimal totalcost = CalculateTotalCost(UI_Item1Cost_Tbx.Text, UI_Item2Cost_Tbx.Text, UI_GST_Cbx.Checked);

            UI_TotalCost_Tbx.Text = totalcost.ToString();
        }
    }
}

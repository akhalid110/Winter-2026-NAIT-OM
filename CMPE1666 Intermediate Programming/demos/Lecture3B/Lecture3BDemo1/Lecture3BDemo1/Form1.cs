/**CMPE 1666-Intermediate programming
 * 
 * Lecture 3B- Demo1
 * 
 * Date: October 06, 2025 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3BDemo1
{
    public partial class Form1 : Form
    { List<int> intList = new List<int>() {5,10,15,20,25,30,35,40,45,50};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI_InitialValues_Tbx.Text = string.Join(", ", intList);
        }

        /// <summary>
        /// Shuffle has as parameter a List. It shuffles the values using the 
        /// Fisher-Yates Shuffling Algorithm
        /// </summary>
        /// <param name="list">The List To be shuffled</param>
        private void Shuffle(List<int> list)
        {
            Random rnd = new Random();

            //Apply the Fisher-Yates Algorithm
            for (int i=list.Count - 1; i > 0; i--)
            {
                //Generate a random value
                int randPosn = rnd.Next(i);

                //Perform a swap between positions i and randPosn
                int temp = list[i];
                list[i] = list[randPosn];
                list[randPosn] = temp;
            }
        }


        /// <summary>
        /// This event handler calls the ShuffleAlgorithm on the List
        /// and displays the results in the right textbox on the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Shuffle_Btn_Click(object sender, EventArgs e)
        {
            Shuffle(intList);
            UI_ShuffledValues_Tbx.Text = string.Join(", ", intList);
        }

        
        /// <summary>
        /// This Event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UI_Reload_Btn_Click(object sender, EventArgs e)
        {
            UI_InitialValues_Tbx.Text = string.Join(", ", intList);
            UI_ShuffledValues_Tbx.Clear();
        }
    }
}

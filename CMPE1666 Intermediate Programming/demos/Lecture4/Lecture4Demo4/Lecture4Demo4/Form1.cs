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

namespace Lecture4Demo4
{
    public partial class Form1 : Form
    {
        private string _fileName;
        public Form1()
        {
            InitializeComponent();
            label1.AllowDrop = true;
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            _fileName = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            label1.Text = Path.GetFileName(_fileName);
            MessageBox.Show($"{_fileName}");

        }

        private void UI_DisplayData_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_fileName))
            {
                MessageBox.Show("Please drag and drop a file first.");
                return;
            }

            UI_DisplayData_Lbx.Items.Clear();
            try
            {
                foreach (string line in File.ReadAllLines(_fileName))
                {
                    UI_DisplayData_Lbx.Items.Add(line);
                }
            }
            catch (Exception ex)
            {                                      
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
    }
}

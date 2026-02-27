using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le1Q2
{
    public partial class Form1 : Form
    {
        // List<T> member variable (Lecture 3 Lists) :contentReference[oaicite:3]{index=3}
        private List<int> _values = new List<int>();
        private Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // Default radio selection (matches screenshot)
            UI_ObtainValues_Radio.Checked = true;

            // Hook up events (Lecture 2: event handlers on controls) :contentReference[oaicite:4]{index=4}
            UI_ObtainValues_Radio.CheckedChanged += Operation_CheckedChanged;
            UI_SumValues_Radio.CheckedChanged += Operation_CheckedChanged;
            UI_Search_Radio.CheckedChanged += Operation_CheckedChanged;

            UI_GenerateValues_Btn.Click += UI_GenerateValues_Btn_Click;
            UI_Sum_Btn.Click += UI_Sum_Btn_Click;
            UI_Search_Btn.Click += UI_Search_Btn_Click;

            UpdateUIForMode();
        }

        // Consolidated handler for radio buttons
        private void Operation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIForMode();
        }

        // Enable/disable controls based on selected operation
        private void UpdateUIForMode()
        {
            bool obtain = UI_ObtainValues_Radio.Checked;
            bool sum = UI_SumValues_Radio.Checked;
            bool search = UI_Search_Radio.Checked;

            // Obtain Values mode
            UI_GenerateValues_Btn.Enabled = obtain;
            UI_LowerLimit_Tbx.Enabled = obtain;
            Ui_UpperLimit_Tbx.Enabled = obtain;
            UI_NumValues_Tbx.Enabled = obtain;

            // Sum mode
            UI_Sum_Btn.Enabled = sum;
            UI_Sum_Tbx.Enabled = sum; // can be ReadOnly in designer

            // Search mode
            UI_Search_Btn.Enabled = search;
            UI_Search_Tbx.Enabled = search;

            // Clear outputs when switching modes (optional but clean)
            if (!sum) UI_Sum_Tbx.Text = "";
            if (!search)
            {
                UI_Search_Tbx.Text = "";
                UI_SearchValues_Lbx.Items.Clear();
            }
        }

        // ------------------- BUTTON: Generate Values -------------------
        private void UI_GenerateValues_Btn_Click(object sender, EventArgs e)
        {
            // validate inputs with TryParse (simple + safe)
            if (!int.TryParse(UI_LowerLimit_Tbx.Text, out int low))
            {
                MessageBox.Show("Lower Limit must be a valid integer.");
                return;
            }

            if (!int.TryParse(Ui_UpperLimit_Tbx.Text, out int high))
            {
                MessageBox.Show("Upper Limit must be a valid integer.");
                return;
            }

            if (!int.TryParse(UI_NumValues_Tbx.Text, out int count))
            {
                MessageBox.Show("Number of Values must be a valid integer.");
                return;
            }

            if (count <= 0)
            {
                MessageBox.Show("Number of Values must be greater than 0.");
                return;
            }

            if (low > high)
            {
                MessageBox.Show("Lower Limit must be <= Upper Limit.");
                return;
            }

            // clear old data
            _values.Clear();
            UI_ListValues_Lbx.Items.Clear();
            UI_SearchValues_Lbx.Items.Clear();
            UI_Sum_Tbx.Text = "";

            // generate random values and display
            for (int i = 0; i < count; i++)
            {
                int v = _rand.Next(low, high + 1); // inclusive upper bound
                _values.Add(v);
                UI_ListValues_Lbx.Items.Add(v);
            }
        }

        // ------------------- BUTTON: Sum of Even Values -------------------
        private void UI_Sum_Btn_Click(object sender, EventArgs e)
        {
            if (_values.Count == 0)
            {
                MessageBox.Show("No values yet. Generate values first.");
                return;
            }

            int sum = 0;

            // foreach over List<T> (Lecture 3) :contentReference[oaicite:5]{index=5}
            foreach (int v in _values)
            {
                if (v % 2 == 0)
                    sum += v;
            }

            UI_Sum_Tbx.Text = sum.ToString();
        }

        // ------------------- BUTTON: Perform Search -------------------
        private void UI_Search_Btn_Click(object sender, EventArgs e)
        {
            if (_values.Count == 0)
            {
                MessageBox.Show("No values yet. Generate values first.");
                return;
            }

            if (!int.TryParse(UI_Search_Tbx.Text, out int target))
            {
                MessageBox.Show("Search Value must be a valid integer.");
                return;
            }

            UI_SearchValues_Lbx.Items.Clear();

            // Find all matches and show them in the right listbox
            foreach (int v in _values)
            {
                if (v == target)
                    UI_SearchValues_Lbx.Items.Add(v);
            }

            // If nothing found, you can optionally show a message
            if (UI_SearchValues_Lbx.Items.Count == 0)
                UI_SearchValues_Lbx.Items.Add("No matches");
        }
    }
}

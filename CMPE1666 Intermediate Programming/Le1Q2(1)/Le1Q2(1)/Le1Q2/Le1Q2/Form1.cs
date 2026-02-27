using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Le1Q2
{
    public partial class Form1 : Form
    {
        // List to store generated values
        private List<int> _values = new List<int>();
        private Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // Default mode
            UI_ObtainValues_Radio.Checked = true;

            // Radio button handlers
            UI_ObtainValues_Radio.CheckedChanged += Operation_CheckedChanged;
            UI_SumValues_Radio.CheckedChanged += Operation_CheckedChanged;
            UI_Search_Radio.CheckedChanged += Operation_CheckedChanged;

            // Button handlers
            UI_GenerateValues_Btn.Click += UI_GenerateValues_Btn_Click;
            UI_Sum_Btn.Click += UI_Sum_Btn_Click;
            UI_Search_Btn.Click += UI_Search_Btn_Click;

            UpdateUIForMode();
        }

        // ------------------- RADIO HANDLER -------------------
        private void Operation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUIForMode();
        }

        // Enable / disable controls based on mode
        private void UpdateUIForMode()
        {
            bool obtain = UI_ObtainValues_Radio.Checked;
            bool sum = UI_SumValues_Radio.Checked;
            bool search = UI_Search_Radio.Checked;

            // Obtain mode
            UI_GenerateValues_Btn.Enabled = obtain;
            UI_LowerLimit_Tbx.Enabled = obtain;
            Ui_UpperLimit_Tbx.Enabled = obtain;
            UI_NumValues_Tbx.Enabled = obtain;

            // Sum mode
            UI_Sum_Btn.Enabled = sum;
            UI_Sum_Tbx.Enabled = sum;

            // Search mode
            UI_Search_Btn.Enabled = search;
            UI_Search_Tbx.Enabled = search;

            // Clear outputs when switching modes
            if (!sum)
                UI_Sum_Tbx.Text = "";

            if (!search)
            {
                UI_Search_Tbx.Text = "";
                UI_SearchValues_Lbx.Items.Clear();
            }
        }

        // ------------------- GENERATE VALUES -------------------
        private void UI_GenerateValues_Btn_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Lower Limit must be less than or equal to Upper Limit.");
                return;
            }

            // Clear old data
            _values.Clear();
            UI_ListValues_Lbx.Items.Clear();
            UI_SearchValues_Lbx.Items.Clear();
            UI_Sum_Tbx.Text = "";

            // Generate values
            for (int i = 0; i < count; i++)
            {
                int v = _rand.Next(low, high + 1);
                _values.Add(v);
                UI_ListValues_Lbx.Items.Add(v);
            }
        }

        // ------------------- SUM EVEN VALUES -------------------
        private void UI_Sum_Btn_Click(object sender, EventArgs e)
        {
            if (_values.Count == 0)
            {
                MessageBox.Show("No values yet. Generate values first.");
                return;
            }

            int sum = 0;

            foreach (int v in _values)
            {
                if (v % 2 == 0)
                    sum += v;
            }

            UI_Sum_Tbx.Text = sum.ToString();
        }

        // ------------------- SEARCH (INDEX + VALUE) -------------------
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

            bool found = false;

            // for-loop gives index + value
            for (int i = 0; i < _values.Count; i++)
            {
                if (_values[i] == target)
                {
                    UI_SearchValues_Lbx.Items.Add($"Index {i} : {_values[i]}");
                    found = true;
                }
            }

            if (!found)
                UI_SearchValues_Lbx.Items.Add("No matches");
        }
    }
}
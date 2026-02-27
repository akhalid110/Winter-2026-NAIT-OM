using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LE_Practice_2
{
    public partial class Form1 : Form
    {
        private struct Employee
        {
            public int Id;
            public int Grade;
            public int Salary;
        }

        private List<Employee> _emps = new List<Employee>();
        private string[] _rawLines = null;
        private Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // Drop happens on the LABEL now
            UI_Drop_Lbl.AllowDrop = true;

            UI_Drop_Lbl.DragEnter += UI_Drop_Lbl_DragEnter;
            UI_Drop_Lbl.DragDrop += UI_Drop_Lbl_DragDrop;

            UI_DisplayStructs_Btn.Click += UI_DisplayStructs_Btn_Click;
            UI_ShuffleData_Btn.Click += UI_ShuffleData_Btn_Click;
        }

        private string EmployeeToString(Employee e)
        {
            return $"ID: {e.Id}, grade: {e.Grade}, salary: ${e.Salary}";
        }

        // DragEnter on LABEL
        private void UI_Drop_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // DragDrop on LABEL
        private void UI_Drop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files == null || files.Length == 0) return;

            string fname = files[0];

            _rawLines = File.ReadAllLines(fname);

            // Clear everything if dropped again
            UI_File_Lbx.Items.Clear();
            UI_Employees_Lbx.Items.Clear();
            _emps.Clear();

            foreach (string line in _rawLines)
                UI_File_Lbx.Items.Add(line);
        }

        private void UI_DisplayStructs_Btn_Click(object sender, EventArgs e)
        {
            if (_rawLines == null) return;

            _emps.Clear();
            UI_Employees_Lbx.Items.Clear();

            foreach (string line in _rawLines)
            {
                string[] parts = line.Split(',');
                if (parts.Length < 3) continue;

                int id, grade, salary;

                if (!int.TryParse(parts[0].Trim(), out id)) continue;
                if (!int.TryParse(parts[1].Trim(), out grade)) continue;
                if (!int.TryParse(parts[2].Trim(), out salary)) continue;

                Employee emp;
                emp.Id = id;
                emp.Grade = grade;
                emp.Salary = salary;

                _emps.Add(emp);
            }

            foreach (Employee emp in _emps)
                UI_Employees_Lbx.Items.Add(EmployeeToString(emp));
        }

        private void ShuffleEmployees()
        {
            for (int i = _emps.Count - 1; i > 0; i--)
            {
                int r = _rand.Next(0, i + 1);

                Employee temp = _emps[i];
                _emps[i] = _emps[r];
                _emps[r] = temp;
            }
        }

        private void UI_ShuffleData_Btn_Click(object sender, EventArgs e)
        {
            if (_emps.Count == 0) return;

            UI_Employees_Lbx.Items.Clear();

            ShuffleEmployees();

            foreach (Employee emp in _emps)
                UI_Employees_Lbx.Items.Add(EmployeeToString(emp));
        }
    }
}

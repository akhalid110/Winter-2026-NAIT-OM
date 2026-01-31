using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3Demo5
{
    public partial class Form1 : Form
    {  
        struct Student
        {
            public int _studentId;
            public string _FirstName;
            public string _LastName;
        }
        List<Student> students = new List<Student>();
        List<int> StuID = new List<int>() { 105, 102, 110, 101, 108, 103, 109, 104, 107, 106 };
        List<string> FName = new List<string>() { "John", "Mary", "Alex", "Sara", "David", "Emma", "Chris", "Linda", "Mike", "Sophia"};
        List<string> LName = new List<string>() { "Smith", "Brown", "Johnson", "Lee", "Wilson", "Clark", "Hall", "Lewis", "Young", "Walker"};


        public Form1()
        {
            InitializeComponent();
        }
        private string StudentToString(Student student)
        {
            return $"{student._studentId} , {student._FirstName} , {student._LastName}";
        }

        private Student MaxId(List <Student> students)
        {
            Student maxStudent = students[0];
            foreach (Student s in students)
            {
                if(s._studentId > maxStudent._studentId)
                {
                    maxStudent = s;
                }
            }
            return maxStudent;
        }

        private Student MinId(List<Student> stu)
        {
            Student minStudent = stu[0];
            foreach (Student s in stu)
            {
                if (s._studentId < minStudent._studentId)
                {
                    minStudent = s;
                }
            }
            return minStudent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<10; i++)
            {
                Student s = new Student();
                s._studentId = StuID[i];
                s._FirstName = FName[i];
                s._LastName = LName[i];

                students.Add(s);
                UI_Display_Lbx.Items.Add(StudentToString(s));

            }

        }

        private void UI_MaxID_Btn_Click(object sender, EventArgs e)
        {
            Student maxStu = MaxId(students);
            UI_MaxID_Tbx.Text = maxStu._studentId.ToString();
            UI_StudentID_Tbx.Text = maxStu._studentId.ToString();
            UI_FirstName_Tbx.Text = maxStu._FirstName;
            UI_LastName_Tbx.Text = maxStu._LastName;

        }

        private void UI_MinID_Btn_Click(object sender, EventArgs e)
        {
            Student minStu = MinId(students);
            UI_MinID_Tbx.Text = minStu._studentId.ToString();
            UI_StudentID_Tbx.Text = minStu._studentId.ToString();
            UI_FirstName_Tbx.Text = minStu._FirstName;
            UI_LastName_Tbx.Text = minStu._LastName;
        }

        private void UI_Display_Lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = UI_Display_Lbx.SelectedIndex;

            if (index == -1)
                return;

            Student selectedStudent = students[index];
            UI_StudentID_Tbx.Text = selectedStudent._studentId.ToString();
            UI_FirstName_Tbx.Text = selectedStudent._FirstName;
            UI_LastName_Tbx.Text = selectedStudent._LastName;
            
        }

        private void UI_ModifyStudent_Btn_Click(object sender, EventArgs e)
        {
            int index = UI_Display_Lbx.SelectedIndex;

            if (index == -1)
                return;

            Student updatedStudent = students[index];

            updatedStudent._FirstName = UI_FirstName_Tbx.Text;
            updatedStudent._LastName = UI_LastName_Tbx.Text;

            students[index] = updatedStudent;

            UI_Display_Lbx.Items.Clear();

            foreach (Student s in students)
            {
                UI_Display_Lbx.Items.Add(StudentToString(s));
            }

            UI_Display_Lbx.SelectedIndex = index;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_Demo2
{
    internal class CStudent
    {
        private string _name;
        private double _grade;
        private decimal _fees_due;

        //User-defined constructor
        public CStudent(string name, double grade)
        {
            _name = name;
            _grade = grade;
        }

        public CStudent(string name, double grade, decimal fees):this(name, grade)
        {
            _fees_due = fees;
        }

        //user-defined constructor with only the name as parameter
        public CStudent(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return $"Name: {_name}, grade: {_grade}, fees: {_fees_due}";

        }
    }
}

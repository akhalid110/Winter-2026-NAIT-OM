using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Demo2
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

        public CStudent(string name, double grade, decimal fees) : this(name, grade)
        {
            _fees_due = fees;
        }

        //user-defined constructor with only the name as parameter
        public CStudent(string name)
        {
            _name = name;
        }

        // Including a default 
        public CStudent() : this("unknown", 50, 500)
        {
        }

        public override string ToString()
        {
            return $"Name: {_name}, grade: {_grade}, fees: {_fees_due}";
        }

        //Increase the _grade data member by the upgradeValue, and capped at 100 
        public void Upgrade(double upgradeValue = 10)
        {
            _grade = _grade + upgradeValue < 100 ? _grade + upgradeValue : 100;

        }

        //Methods
        public void AssignName(string name)
        {
            this._name = name;
        }

        public void AssignGrade(double grade)
        {
            this._grade = grade;
        }
        public void AssignFees(decimal fees)
        {
            _fees_due = fees;
        }
    }
}

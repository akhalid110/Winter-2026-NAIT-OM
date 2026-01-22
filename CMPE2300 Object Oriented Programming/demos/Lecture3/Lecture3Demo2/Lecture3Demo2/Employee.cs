using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Demo2
{
    internal class Employee
    {

        public string FullName
        {
            get;
            set;
        } 

        //If we dont't want clients of the class to allow assigning to a property,
        // we make the "Set" private
        public string Id { get; private set; }


        //We'll use the property directly in our constructor
        public Employee(string name)
        {
            FullName = name;
        }

        public Employee(string name , string Id)
        {
            FullName = name;
            this.Id = Id;
        }

        //Leveraging the one-parameter constructor to create the default constructor
        public Employee():this("Om Patel")
        {

        }
        public override string ToString()
        {
            return $"Name:- {FullName} and Id:- {Id}";
        }
    }
}

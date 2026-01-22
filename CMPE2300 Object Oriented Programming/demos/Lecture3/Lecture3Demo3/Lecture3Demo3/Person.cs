using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3Demo3
{
    internal class Person
    {
        private string? _firstName;
        private string? _lastName;
        private string? _fullName;

        //static property
        public static string Language
        {
            get => "English";

        }

        //Propety for _firstName
        public string? FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                _fullName = null;
            }
        }

        //Propety for _lastName
        public string? LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                _fullName = null;
            }
        }

        //Propety for _fullName
        public string? FullName
        {
            get
            {
                if (_fullName is null)
                {
                    _fullName = $"{FirstName} {LastName}";
                }
                return _fullName;
            }
        }
    }
}

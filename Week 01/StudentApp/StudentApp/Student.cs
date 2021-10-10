using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        // Instance variables and properties, pp. 111-112, 118

        /* private string _lastName; // Not needed with short form 

        * public string StudentLastName // Long form
        * {
        *    get
        *    {
        *        return _lastName;
        *    }
        *    set
        *    {
        *        _lastName = value;
        *    }
        } */

        public string StudentLastName { get; set; } // Short form

        public string StudentFirstName { get; set; }

        public string StudentFullName // Read only
        {
            get
            {
                return StudentFirstName + " " + StudentLastName;
            }

        }

        // public int CurrentCredits { get; set; }

        private int _current;

        public int CurrentCredits
        {
            get { return _current; }
            set 
            {
                if (value <= 18) // Check credits
                {
                    _current = value;
                } else
                {
                    throw new Exception("Credit limit exceeded"); //pp. 524
                }
            }
        }


        // Methods, pp. 109

        public void AddCredits()
        {
            CurrentCredits += 3;
        }

        // Constructors, pp. 123
        public Student(string first, string last)
        {
            StudentFirstName = first;
            StudentLastName = last;
            CurrentCredits = 0; // Not needed. 0 is default.
        }

        public Student() // No name provided
        {
            StudentFirstName = "Biff";
            StudentLastName = "Arfus";
        }
    }
}

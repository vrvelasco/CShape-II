using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_console
{
    class Student
    {
        //Instance variables and properties, pp. 111-112, 118

        public string StudentLastName { get; set; }

        public string StudentFirstName { get; set; }

        public string StudentFullName
        {
            get
            {
                return StudentFirstName + " " + StudentLastName;
            }
        }

        private int _current;

        public int CurrentCredits
        {
            get { return _current; }
            private set
            {
                if (value <= 18)
                {
                    _current = value;
                }
                else
                {
                    throw new Exception("Credit limit exceeded");
                }
            }
        }

        public int TotalCredits { get; set; }

        //Methods, p. 109

        public void AddCredits()
        {
            CurrentCredits += 3;
        }

        public void AddCredits(int newCredits)
        {
            CurrentCredits += newCredits;
        }


        public string ShowStudent()
        {
            return $"{StudentFullName}\t{CurrentCredits}\t{TotalCredits}";
        }

        public void ResetCredits()
        {
            TotalCredits += CurrentCredits;
            CurrentCredits = 0;
        }

        //Constructors, p. 123

        public Student(string first, string last)
        {
            StudentFirstName = first;
            StudentLastName = last;
            CurrentCredits = 0;
            TotalCredits = 0;
        }

        public Student(string first, string last, int transfer)
        {
            StudentFirstName = first;
            StudentLastName = last;
            CurrentCredits = 0;
            TotalCredits = transfer;
        }

        public Student()
        {
            StudentFirstName = "Biff";
            StudentLastName = "Arfus";
            CurrentCredits = 0;
            TotalCredits = 0;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppPt3
{
    class Student
    {
        //instance variables, p. 111-112

         private int _curCredits;

        //constructors, p. 123

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

        //properties, p. 118


        public string StudentLastName { get; set; }

        public string StudentFirstName { get; set;}

        public string FullName
        {
            get
            {
                return $"{StudentFirstName} {StudentLastName}";

            }
        }

        public int CurrentCredits
        {
            get
            {
                return _curCredits;
            }
            private set
            {
                if (value <= 18)
                {
                    _curCredits = value;
                }
                //else
                //{
                //    throw new Exception();
                //}
            }
        }

        public int TotalCredits { get; set; }

        //methods, p. 109

        public void AddCredits()
        {
            CurrentCredits += 3;

        }

        public void AddCredits(int newCredits)
        {
            CurrentCredits += newCredits;

        }

        public void ResetCredits()
        {
            TotalCredits += CurrentCredits;
            CurrentCredits = 0;
        }

        public string ShowStudent()
        {
            return $"{FullName,-15}{CurrentCredits, -10}{TotalCredits, -5}";
        }

    }
}

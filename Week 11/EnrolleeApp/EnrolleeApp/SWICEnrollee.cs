using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolleeApp
{
    public abstract class SWICEnrollee
    {
        //static variable

        private static int maxCredits = 18;

        //instance variables, p. 111-112

        private int _curCredits;


        //constructors, p. 123

        public SWICEnrollee(string first, string last)
        {
            StudentFirstName = first;
            StudentLastName = last;
            CurrentCredits = 0;
            TotalCredits = 0;
        }

        public SWICEnrollee(string first, string last, int transfer)
        {
            StudentFirstName = first;
            StudentLastName = last;
            CurrentCredits = 0;
            TotalCredits = transfer;
        }

        //properties, p. 118

        public double TuitionRate { get; } = 106; // Auto initialized, p. 316

        private static int MaxCredits
        {
            get
            {
                return maxCredits;
            }
            set
            {
                maxCredits = value;
            }
        }
        public string StudentLastName { get; set; }

        public string StudentFirstName { get; set; }

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
            set
            {
                if (value <= maxCredits)
                {
                    _curCredits = value;
                }
            }
        }


        private int _lastname;

        public int LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
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
            return $"{FullName,-15}{CurrentCredits,10}{TotalCredits,10}";
        }

        public static void RaiseMaxCredits()
        {
            MaxCredits = 21;
        }

    }
}

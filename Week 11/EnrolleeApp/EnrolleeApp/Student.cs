using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolleeApp
{
    class Student : SWICEnrollee, IPaysTuition
    {
        public Student(string first, string last) :base(first, last) { }
        
        public Student(string first, string last, int transfer) : base(first, last, transfer) { }


        public double Tuition { get => CurrentCredits * TuitionRate; } // p. 273

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolleeApp
{
    class Faculty : SWICEnrollee, IPaysTuition
    {
        public Faculty(string first, string last) : base(first, last) { }

        public double Tuition { get => CurrentCredits * TuitionRate * 0.25; } // p. 273

    }
}

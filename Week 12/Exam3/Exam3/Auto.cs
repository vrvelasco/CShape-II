using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Auto : Vehicle
    {
        public double Gallons { get => Miles / MPG; }

        public double MPG { get; }

        public virtual double Cost { get => Miles / MPG * 4.00; }

        public Auto(string n, double mi, double m) : base(n, mi)
        {
            Name = n;
            Miles = mi;
            MPG = m;
            Speed = 65;
        }
    }
}

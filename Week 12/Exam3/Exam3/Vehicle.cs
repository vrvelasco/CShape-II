using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Vehicle
    {
        public string Name { get; set; }

        public virtual double Speed { get; set; }

        public double Miles { get; set; }

        public double Hours { get => Miles / Speed; }

        public Vehicle(string n, double m)
        {
            Name = n;
            Miles = m;
        }
    }
}

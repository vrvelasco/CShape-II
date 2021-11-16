using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class PHEV : Auto
    {
        public override double Cost { get => (Miles - Range) / MPG * 4.00; }

        public double Range { get; set; }

        public PHEV(string n, double mi, double m, double r) : base(n, mi, m)
        {
            Range = r;
        }
    }
}

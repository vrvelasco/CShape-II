using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    abstract class TwoDimensionalShape : Shape
    {
        public abstract double Area { get; }

        public TwoDimensionalShape(string n, double s) : base(n, s) { }

        public override string ToString() => "Two-Dimensional Shape: ";
    }
}

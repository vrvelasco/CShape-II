using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    abstract class ThreeDimensionalShape : Shape
    {
        public abstract double Area { get; }
        public abstract double Volume { get; }

        public ThreeDimensionalShape(string n, double s) : base(n, s) { }

        public override string ToString() => "Three-Dimensional Shape: ";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Cube : ThreeDimensionalShape
    {
        public override double Area => 6 * Math.Pow(Size, 2);

        public override double Volume => Math.Pow(Size, 3);

        public Cube(string n, double s) : base(n, s) { }

        public override string ToString() => $"{base.ToString()}{Name}";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Sphere : ThreeDimensionalShape
    {
        public override double Area => 4 * Math.PI * Math.Pow(Size, 2);

        public override double Volume => (4.0/3.0) * Math.PI * Math.Pow(Size, 3);

    public Sphere(string n, double s) : base(n, s) { }

        public override string ToString() => $"{base.ToString()}{Name}";
    }
}

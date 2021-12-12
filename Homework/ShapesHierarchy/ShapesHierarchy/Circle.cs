using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Circle : TwoDimensionalShape
    {
        public override double Area => Math.PI * Math.Pow(Size, 2);
        
        public Circle(string n, double s) : base(n, s) { }

        public override string ToString() => $"{base.ToString()}{Name}";
    }
}

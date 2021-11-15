using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Square : TwoDimensionalShape
    {
        public override double Area => Math.Pow(Size, 2); 
        //6 * Math.Pow(Size, 2); >>> I found a different formula online. <<<

        public Square(string n, double s) : base(n, s) { }

        public override string ToString() => $"{base.ToString()}{Name}";
    }
}

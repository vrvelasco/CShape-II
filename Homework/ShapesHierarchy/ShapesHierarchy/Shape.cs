using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Shape
    {
        public string Name { get; }
        public double Size { get; set; }
    
    public Shape(string n, double s)
        {
            Name = n;
            Size = s;
        }
    }
}

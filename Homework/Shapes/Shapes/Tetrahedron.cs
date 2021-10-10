using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Tetrahedron
    {
        // Constructors
        public Tetrahedron()
        {
            Size = 1;
        }

        public Tetrahedron(double s)
        {
            Size = s;
        }

        // Properties
        private double _size;

        public double Size
        {
            get { return _size; }
            set
            {
                if (value > 0)
                    _size = value;
                else
                    throw new Exception("Shapes cannot have a negative size.");
            }
        }

        public double SurfaceArea
        {
            get { return Math.Sqrt(3 * Math.Pow(Size, 2)); }
        }

        public double Volume
        {
            get { return (1 / 12D) * Math.Sqrt(2 * Math.Pow(Size, 3)); }
        }

        // Methods
        public double Enlarge(double e)
        {
            return Size += Size * (e / 100);
        }
    }
}

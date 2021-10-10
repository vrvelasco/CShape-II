using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Sphere
    {
        // Constructors
        public Sphere()
        {
            Size = 1;
        }

        public Sphere(double s)
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
            get { return 4 * Math.PI * Math.Pow(Size, 2); }
        }

        public double Volume
        {
            get { return (4/3D) * Math.PI * Math.Pow(Size, 2); }
        }

        // Methods
        public double Enlarge(double e)
        {
            return Size += Size * (e / 100);
        }
    }
}

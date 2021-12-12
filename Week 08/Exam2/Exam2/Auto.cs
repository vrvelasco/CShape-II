using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Auto
    {
        private double _cost;

        public Auto(string vin, string mm, double cost)
        {
            VIN = vin;
            Cost = cost;
            MakeModel = mm;
        }

        public string VIN { get; set; }
        public string MakeModel { get; set; }

        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value >= 0)
                {
                    _cost = value;
                }
            }
        }
        public double List
        {
            get
            {
                return Cost * (1+(Margin/100));
            }
        }
        public double Profit
        {
            get
            {
                return List - Cost;
            }
        }

        private static double _margin =10;

        public static double Margin 
        {
            get { return _margin; }
            set
            {
                if (_margin >= 0)
                    _margin = value;
                else
                    _margin = 0;
            }
        }

        // Methods
        public static void  IncreaseMargin()
        {
            Margin += 2;
        }

        public static void DecreaseMargin()
        {
            Margin -= 2;
        }

    }
}

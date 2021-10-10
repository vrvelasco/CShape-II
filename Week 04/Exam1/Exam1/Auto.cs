using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Auto
    {
        // Constructor
        public Auto(string v, string m, double c)
        {
            VIN = v;
            MakeModel = m;
            Cost = c;
        }

        // Properties
        public string VIN { get; set; }
        public string MakeModel { get; set; }
        private double _current;

        public double Cost
        {
            get { return _current; }
            set
            {
                if (value >= 0)
                    _current = value;
                else
                    _current = 0; // Error
            }
        }
        public double ListPrice
        {
            get
            { return Cost * 1.1; }
        }
        public double Profit
        {
            get
            { return ListPrice - Cost; }
        }

        // Method
        public string Details()
        {
            return $" {VIN,-20} {MakeModel, -30} {Cost,15:C} {ListPrice, 15:C} {Profit, 15:C}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHierarchy
{
    class SavingsAccount : Account
    {
        private int _rate;

        public int Rate { get; set; }
        
        public SavingsAccount(decimal b, int r) : base(b)
        {
            // Base class handles balance
            Rate = r;
        }

        public decimal CalculateInterest()
        {
            return Balance * ((decimal)Rate / 100);
        }
    }
}

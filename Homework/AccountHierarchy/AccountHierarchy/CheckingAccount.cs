using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHierarchy
{
    class CheckingAccount : Account
    {
        private decimal _fee;

        public decimal Fee { get; set; }

        public CheckingAccount(decimal b, decimal f) : base(b)
        {
            Fee = f;
        }

        public new void Credit(decimal c)
        {
            base.Credit(c); // Credit account
            Balance -= Fee; // Charge fee
        }

        public new void Debit(decimal d)
        {
            if (base.Debit(d)) // If true, debit account
                Balance -= Fee; // Charge fee
        }
    }
}

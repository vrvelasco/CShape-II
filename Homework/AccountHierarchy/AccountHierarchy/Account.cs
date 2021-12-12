using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHierarchy
{
    class Account
    {
        public Account(decimal b)
        {
            Balance = b;
        }

        private decimal _balance;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value >= 0.0M)
                    _balance = value;
                else
                    throw new Exception("Inital balance cannot be less than zero.");
            }
        }

        public void Credit(decimal c)
        {
            if (c > 0.0M)
                Balance += c;
        }

        public bool Debit(decimal d)
        {
            if (Balance > d)
            {
                Balance -= d;
                return true;
            }
            else
            {
                //return false;
                throw new Exception("Debit amount exceeded account balance.");
            }
        }
    }
}

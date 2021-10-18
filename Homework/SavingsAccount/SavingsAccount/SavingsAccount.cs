using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccount
{
    class SavingsAccount
    {
        // Constructor
        public SavingsAccount(double b)
        {
            SavingsBalance = b;
        }

        // Properties
        private static double annualInterestRate;
        public static double AnnualInterestRate
        {
            get
            {
                return annualInterestRate;
            }
            set
            {
                annualInterestRate = value;
            }
        }

        private double savingsBalance;
        public double SavingsBalance
        {
            get
            {
                return savingsBalance;
            }
            set
            {
                if (value < 0)
                    savingsBalance = 0;
                else
                    savingsBalance = value;
            }
        }

        public double AccruedInterest { get; set; }

        // Method
        public void CalculateMonthlyInterest()
        {
            AccruedInterest = (SavingsBalance * (AnnualInterestRate / 100)) / 12;
            SavingsBalance += AccruedInterest;
        }
    }
}

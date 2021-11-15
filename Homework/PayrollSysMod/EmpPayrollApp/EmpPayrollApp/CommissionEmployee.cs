using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollApp
{
    public class CommissionEmployee : Employee
    {
        private decimal grossSales; // gross weekly sales 
        private decimal commissionRate; // commission percentage

        // five-parameter constructor
        public CommissionEmployee(string firstName, string lastName,
           string socialSecurityNumber, decimal grossSales,
           decimal commissionRate) : base(firstName, lastName, socialSecurityNumber)
        {
            // implicit call to object constructor occurs here             
            GrossSales = grossSales; // validates gross sales
            CommissionRate = commissionRate; // validates commission rate
        }

        // property that gets and sets commission employee's gross sales
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value < 0) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(GrossSales)} must be >= 0");
                }

                grossSales = value;
            }
        }

        // property that gets and sets commission employee's commission rate
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if (value <= 0 || value >= 1) // validation
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                       value, $"{nameof(CommissionRate)} must be > 0 and < 1");
                }

                commissionRate = value;
            }
        }

        // calculate commission employee's pay
        public override decimal Earnings() => commissionRate * grossSales;

        // return string representation of CommissionEmployee object
        public override string ToString() =>
           $"Commission {base.ToString()}" +
           $"Gross sales: {grossSales:C}\n" +
           $"Commission rate: {commissionRate:F2}\n" +
            $"Total earnings: {Earnings():C}";
    }
}

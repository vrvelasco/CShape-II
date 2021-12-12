using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollApp
{
    public class CommissionEmployee : object
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        private decimal grossSales; // gross weekly sales 
        private decimal commissionRate; // commission percentage

        // five-parameter constructor
        public CommissionEmployee(string firstName, string lastName,
           string socialSecurityNumber, decimal grossSales,
           decimal commissionRate)
        {
            // implicit call to object constructor occurs here             
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
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
        public virtual decimal Earnings() => commissionRate * grossSales;

        // return string representation of CommissionEmployee object
        public override string ToString() =>
           $"commission employee: {FirstName} {LastName}\n" +
           $"social security number: {SocialSecurityNumber}\n" +
           $"gross sales: {grossSales:C}\n" +
           $"commission rate: {commissionRate:F2}";
    }
}

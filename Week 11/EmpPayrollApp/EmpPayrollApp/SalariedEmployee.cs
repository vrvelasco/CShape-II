using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollApp
{
    public class SalariedEmployee : Employee
    {
        public SalariedEmployee(string first, string last, string ss, decimal weekly) : base(first, last, ss)
        {
            WeeklySalary = weekly;
        }

        public decimal WeeklySalary { get; set; }

        public override decimal Earnings() => WeeklySalary;

        public override string ToString() =>
          $"{base.ToString()}" +
           $"Weekly salary: {WeeklySalary:C}\n";
    }
}

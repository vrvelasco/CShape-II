using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {

        // Constructor
        public Employee(string name, long phone, double monthly)
        {
            Name = name;
            Phone = phone;
            MonthlySalary = monthly;
        }

        // Properties
        public string Name { get; set; }
        public long Phone { get; set; }

        private double _salary;

        public double MonthlySalary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                    _salary = value;
                else
                    throw new Exception("Salaries cannot be negative.");
            }
        }

        public double AnnualSalary
        {
            get
            {
                return MonthlySalary * 12;
            }
        }

        // Methods
        public void Raise()
        {
            MonthlySalary *= 1.1;
        }
    }
}

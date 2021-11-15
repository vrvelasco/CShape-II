using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollApp
{
    public abstract class Employee
    {

        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        public Employee(string firstName, string lastName,
           string socialSecurityNumber)
        {
            // implicit call to object constructor occurs here             
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
        public abstract decimal Earnings();
		
        public override string ToString() =>
           $"\nEmployee: {FirstName} {LastName}\n" +
           $"Social security number: {SocialSecurityNumber}\n";

    }
}

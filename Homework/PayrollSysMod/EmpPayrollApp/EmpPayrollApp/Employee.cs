using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollApp
{
    public class Employee
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
        public virtual decimal Earnings() {
            return 0;
        }
        public override string ToString() =>
           $"Employee: {FirstName} {LastName}\n" +
           $"Social security number: {SocialSecurityNumber}\n";

    }
}

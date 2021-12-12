using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> emps = new List<Employee>() {
                // new Employee("Biff", "Arfus", "111-11-1111"), *** Cannot instantiate abstract class
                new SalariedEmployee("Biff", "Arfus", "111-11-1111", 10000.0M),
                new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00m, .06m),
                new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00m, .04m, 300.0m)
            };

            foreach (Employee e in emps)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}

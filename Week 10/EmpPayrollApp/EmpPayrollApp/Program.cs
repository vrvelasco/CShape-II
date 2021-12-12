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
            CommissionEmployee emp1 = new CommissionEmployee("Sue", "Jones","222-22-2222", 10000.00M,.06M);
            BasePlusCommissionEmployee emp2 = new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00M, 0.04m, 300.0m);

            //Console.WriteLine(emp1.ToString());
            //Console.WriteLine(emp2.ToString());

            DisplayEmp(emp1);
            DisplayEmp(emp2);

            Console.ReadKey();

            void DisplayEmp(CommissionEmployee emp)
            {
                Console.WriteLine($"{"Base Plus Commission",-20}");
                Console.WriteLine($"{"Employee Name:",-20}{emp.FirstName} {emp.LastName}");
                Console.WriteLine($"{"SS#:",-20}{emp.SocialSecurityNumber}");
                Console.WriteLine($"{"Gross Sales:",-20}{emp.GrossSales:C}");
                Console.WriteLine($"{"Commission Rate:",-20}{emp.CommissionRate:P}");
                Console.WriteLine($"{"Earnings:",-20}{emp.Earnings():C}");
                if(emp is BasePlusCommissionEmployee)
                    Console.WriteLine($"{"Base Salary:",-20}{((BasePlusCommissionEmployee)emp).BaseSalary:C}\n");
                else
                    Console.WriteLine($"\n");

            }

            //void DisplayEmp1(CommissionEmployee emp)
            //{
            //    Console.WriteLine($"{"Commission",-20}");
            //    Console.WriteLine($"{"Employee Name:",-20}{emp.FirstName} {emp.LastName}");
            //    Console.WriteLine($"{"SS#:",-20}{emp.SocialSecurityNumber}");
            //    Console.WriteLine($"{"Gross Sales:",-20}{emp.GrossSales:C}");
            //    Console.WriteLine($"{"Commission Rate:",-20}{emp.CommissionRate:P}");
            //    Console.WriteLine($"{"Earnings:",-20}{emp.Earnings():C}\n");
            //}

            //void DisplayEmp2(BasePlusCommissionEmployee emp)
            //{
            //    Console.WriteLine($"{"Base Plus Commission",-20}");
            //    Console.WriteLine($"{"Employee Name:",-20}{emp.FirstName} {emp.LastName}");
            //    Console.WriteLine($"{"SS#:",-20}{emp.SocialSecurityNumber}");
            //    Console.WriteLine($"{"Gross Sales:",-20}{emp.GrossSales:C}");
            //    Console.WriteLine($"{"Commission Rate:",-20}{emp.CommissionRate:P}");
            //    Console.WriteLine($"{"Earnings:",-20}{emp.Earnings():C}");
            //    Console.WriteLine($"{"Base Salary:",-20}{emp.BaseSalary:C}\n");
            //}

        }
    }
}

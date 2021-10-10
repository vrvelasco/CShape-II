using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee[] employees =
            //{
            //    new Employee("Rodrigo", 6185551234, 5000),
            //    new Employee("Javier", 6185554321, 3500),
            //    new Employee("Jenny", 6185550000, 4000)
            //};
            Employee[] employees =
            {
                new Employee("Tom Thompson",1234567890, 1100),
                new Employee("Georgia Kenedy", 1234567890, 1320),
                new Employee("Pete Peterson", 1234567890, 1188),
                new Employee("Meredith Jones", 1234567890, 1795),
                new Employee("Jean Cummings", 1234567890, 1716),
                new Employee("Michael Robbins", 1234567890, 1200),
                new Employee("Polly Marks", 1234567890, -1)
            };

            // Before
            PrintHeading("All employees before raise\n\n");
            DisplayEmployees();

            // After
            PrintHeading("\nAll employees after raise\n\n");
            foreach (Employee e in employees)
            {
                e.Raise();
            }
            DisplayEmployees();

            // Totals
            double totalMonthly = 0.0, totalAnnual = 0.0; // Accumulator variables
            foreach (Employee e in employees)
            {
                totalMonthly += e.MonthlySalary;
                totalAnnual += e.AnnualSalary;
            }

            Console.WriteLine($"\nTotal monthly salary: {totalMonthly:C}\nTotal annual salary: {totalAnnual:C}");

            // Salaries over $1500
            PrintHeading("\nEmployees with salaries over $1,500/month\n");

            bool topSalaries = false;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\n{" #",-3}|{"Name",-15}|{"Phone Number",-13}|{"Monthly",-10}|{"Annual",-10}");
            Console.BackgroundColor = ConsoleColor.Black;

            for (int i = 0; i < employees.Count(); i++)
            {
                if (employees[i].MonthlySalary > 1500)
                {
                    Console.WriteLine($"{(i + 1).ToString(),2}.|{employees[i].Name,-15}|{employees[i].Phone,-13:000-000-0000}|{employees[i].MonthlySalary,10:C2}|{employees[i].AnnualSalary,10:C2}");

                    topSalaries = true; // At least one employee
                }
            }

            if (!topSalaries)
                Console.WriteLine("Not found");

            // Search
            PrintHeading("\nResults of sequential, case insensitive seach for P in reverse order with number included:\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\n{" #",-3}|{"Name",-15}|{"Phone Number",-13}|{"Monthly",-10}|{"Annual",-10}");
            Console.BackgroundColor = ConsoleColor.Black;

            for (int i = (employees.Length - 1); i >= 0; i--)
            {
                if (employees[i].Name.ToLower().Contains("p"))
                {
                    Console.WriteLine($"{(i + 1).ToString(),2}.|{employees[i].Name,-15}|{employees[i].Phone,-13:000-000-0000}|{employees[i].MonthlySalary,10:C2}|{employees[i].AnnualSalary,10:C2}");
                }
            }

            // End of program
            Console.Write("\n ► Press any key to exit ◄ ");
            Console.ReadKey();

            // Methods
            void DisplayEmployees() // Prints employees
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{" #",-3}|{"Name",-15}|{"Phone Number",-13}|{"Monthly",-10}|{"Annual",-10}");
                Console.BackgroundColor = ConsoleColor.Black;

                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine($"{(i + 1).ToString(),2}.|{employees[i].Name,-15}|{employees[i].Phone,-13:000-000-0000}|{employees[i].MonthlySalary,10:C2}|{employees[i].AnnualSalary,10:C2}");
                }
            }

            void PrintHeading(string s)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta; // Highlight row
                foreach (char c in s) // 
                {
                    Console.Write(c);
                    Thread.Sleep(20);
                }
                Console.BackgroundColor = ConsoleColor.Black; // Return to normal
            }
        }
    }
}








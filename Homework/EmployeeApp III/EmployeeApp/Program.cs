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
            List<Employee> employees = new List<Employee>()
            {
                new Employee("Tom Thompson",1234567890, 1100),
                new Employee("Georgia Kenedy", 1234567890, 1320),
                new Employee("Pete Peterson", 1234567890, 1188),
                new Employee("Meredith Jones", 1234567890, 1795),
                new Employee("Jean Cummings", 1234567890, 1716),
                new Employee("Michael Robbins", 1234567890, 1200),
                new Employee("Polly Marks", 1234567890, -1)
            };

            /*
             * PART I
             */

            // Before
            PrintHeading("All employees BEFORE raise\n\n");
            DisplayEmployees();

            // After
            PrintHeading("\nAll employees AFTER raise\n\n");
            foreach (Employee e in employees)
            {
                e.Raise();
            }
            DisplayEmployees();

            // Totals
            double totalMonthly = (from m in employees select m.MonthlySalary).Sum();
            double totalAnnual = (from a in employees select a.AnnualSalary).Sum();

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

            /*
             * PART II
             */

            // Search
            string searchStr = "m";
            PrintHeading($"\nResults of search for employee name beginning with '{searchStr}'\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\n{" #",-3}|{"Name",-15}|{"Phone Number",-13}|{"Monthly",-10}|{"Annual",-10}");
            Console.BackgroundColor = ConsoleColor.Black;

            int intSearch = 0;
            var search = from s in employees
                         where s.Name.ToLower().StartsWith(searchStr)
                         select s;
            foreach(var s in search)
            {
                Console.WriteLine($"{(intSearch + 1).ToString(),2}.|{s.Name,-15}|{s.Phone,-13:000-000-0000}|{s.MonthlySalary,10:C2}|{s.AnnualSalary,10:C2}");
            }

            int indexSearch = employees.IndexOf(search.First()); // Get index
            PrintHeading($"\nEmployees after removing first occurance of employee name beginning with '{searchStr}' at index {indexSearch}\n\n");
            employees.RemoveAt(indexSearch); // Remove employee at that index
            DisplayEmployees();

            /*
             * PART III
             */
            employees.Insert(0, new Employee() { Name = "Victor Velasco" });
            // Before
            PrintHeading($"\nEmployees before increasing raise from {Employee.RaisePercentage}%\n\n");
            DisplayEmployees();

            // After
            Employee.IncreaseRaise(); // Increases the raise percentage.
            PrintHeading($"\nEmployees after increasing raise to {Employee.RaisePercentage}%\n\n");
            foreach (Employee e in employees)
            {
                e.Raise();
            }
            DisplayEmployees();


            // End of program
            Console.Write("\n ► Press any key to exit ◄ ");
            Console.ReadKey();

            // Methods
            void DisplayEmployees() // Prints employees
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{" #",-3}|{"Name",-15}|{"Phone Number",-13}|{"Monthly",-10}|{"Annual",-10}");
                Console.BackgroundColor = ConsoleColor.Black;

                for (int i = 0; i < employees.Count; i++)
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








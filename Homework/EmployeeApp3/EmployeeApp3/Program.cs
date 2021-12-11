using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeEntities db = new EmployeeEntities();

            // Show the set of distinct department codes from the Employee table
            var distinctDept = db.Employees.Select(d => d.deptcode).Distinct();

            PrintColumn("LIST OF DISTINCT DEPARTMENT CODES\n", 'b');

            foreach (var e in distinctDept)
            {
                Console.WriteLine(e.ToString());
            }

            // Show the employee names and department codes of employees with phone numbers in the 618
            // area code in alphabetical order. Display a message if none exist.
            var areaCode = db.Employees.Where(p => p.phone.StartsWith("618")).OrderBy(o => o.lastname);

            PrintColumn("\nEMPLOYEES THAT HAVE PHONE NUMBERS WITH 618 AREA CODES (SORTED BY LAST NAME)\n", 'b');

            if (areaCode.Any()) // Check if someone was found
                PrintEmp(areaCode);
            else
                Console.WriteLine("No employees found!"); // Error message
            // Show the employee names and department codes of employees in the SL department.
            var departSL = db.Employees.Where(d => d.deptcode.Equals("SL"));

            PrintColumn("\nEMPLOYEES IN SL DEPARTMENT\n", 'b');

            PrintEmp(departSL);

            // Show the number of SL employees before and after each of the following changes:
            PrintColumn("\n                             \n*** CRUD OPERATIONS BELOW ***\n                             \n", 'r');

            // Permanently move employee Thomas Smiley to department MK.
            var showMKDept = db.Employees.Where(m => m.deptcode.Equals("MK"));
            var permMove = db.Employees.Where(n => n.firstname.Equals("Thomas") && n.lastname.Equals("Smiley"));

            PrintEmp(permMove);

            PrintColumn("\nPERMANENTLY MOVE THOMAS SMILEY TO MK DEPARTMENT\n", 'b');

            PrintEmp(departSL);


            // Add yourself as an employee to department SL. Note: The only required field in the
            // Employee table is the primary key, id, which is not an identify column and not
            // automatically assigned.Use ‘A0062’ (or higher).
            db.Employees.Add(new Employee() { firstname = "Victor", lastname = "Velasco", id = "A0062", deptcode = "SL" });
            PrintEmp(departSL);

            // Remove your employee record from the table
            //db.Employees.Remove(db.Employees.Where(n => n.id.Equals("A0062")).FirstOrDefault());

            // Exit
            PrintColumn("\nPRESS ANY KEY TO EXIT",'r');
            Console.ReadKey();

            // Formatting
            void PrintColumn(string m, char c)
            {
                if (c.Equals('b'))
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                else
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(m);
                Console.BackgroundColor = ConsoleColor.Black;
            }

            void PrintEmp(IEnumerable<Employee> empList)
            {
                Console.WriteLine($"{"Full Name",-20} {"Department"}\n" +
                    $"{"--------------------", -20} {"----------"}");

                foreach (Employee e in empList)
                {
                    Console.WriteLine($"{e.FullName,-20} {e.deptcode}");
                }
            }
        }
    }

    partial class Employee
    {
        public string FullName { get => $"{firstname} {lastname}"; }
    }
}

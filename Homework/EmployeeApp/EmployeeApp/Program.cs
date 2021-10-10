using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("Rodrigo", 6185551234, 5000),
                new Employee("Javier", 6185554321, 3500),
                new Employee("Jenny", 6185550000, 4000)
            };

            // Display menu and get intial choice from user
            DisplayMenu();
            MenuSelection(CheckChoice());

            void DisplayMenu() // Prints a menu
            {
                // Prompt user
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("MENU".PadLeft(16).PadRight(30));
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("1. Display employees\n2. Give all employees a raise\n3. Exit");
            }

            int CheckChoice() // Check the entry is valid
            {
                int choice = -1; // Holds the user's choice

                while (choice == -1)
                {
                    Console.Write("\nPlease make a selection: ");
                    string userChoice = Console.ReadLine(); // Get the user's choice

                    try
                    {
                        choice = int.Parse(userChoice); // Convert string to int
                        if (choice != 1 && choice != 2 && choice != 3)
                        {
                            Console.WriteLine("\n ► Invalid selection. Please try again.");
                            choice = -1; // Error
                        }
                        else
                            return choice; // Valid number

                    }
                    catch
                    {
                        Console.WriteLine("\n ► Invalid selection. Please try again.");
                        choice = -1; // Error
                    }
                }
                return choice;
            }

            void MenuSelection(int s) // Display the user's selected item
            {
                while (s != 3)
                {
                    switch (s)
                    {
                        case 1: // Display employees
                            Console.Clear(); // Clear screen

                            Console.WriteLine("Displaying current employees: "); // Heading

                            Console.WriteLine(); // Spacing

                            DisplayEmployees();

                            Console.WriteLine(); // Spacing
                            break;
                        case 2: // Give raise
                            Console.Clear(); // Clear screen

                            Console.WriteLine("Before the employee raise:\n");

                            DisplayEmployees(); // Before increase

                            foreach (Employee e in employees) // Give everybody a raise
                            {
                                e.Raise();
                            }

                            Console.WriteLine("\nAfter the employee raise:\n");

                            DisplayEmployees(); // After raise

                            Console.WriteLine(); // Spacing
                            break;
                    }

                    // Start over
                    DisplayMenu();
                    MenuSelection(CheckChoice());

                    s = 3;  // This allows the Exit function of the menu work.
                }

                // Exit screen
                //Console.Write("\nPress any key to exit ");
            }

            void DisplayEmployees() // Prints employees
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{"Name",-8} | {"Phone #",-12} | {"Monthly",-10} | {"Annual",-10}");

                for (int i = 0; i < employees.Length; i++)
                {
                    if (i % 2 == 0) // Changes color of rows
                        Console.BackgroundColor = ConsoleColor.Black;
                    else
                        Console.BackgroundColor = ConsoleColor.DarkGray;

                    Console.WriteLine($"{employees[i].Name,-8} | {employees[i].Phone,-10:000-000-0000} | {employees[i].MonthlySalary,-10:C2} | {employees[i].AnnualSalary,-10:C2}");

                }
            }
        }
    }
}








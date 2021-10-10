using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos = {
            new Auto("3KFKLSO93MN4K3H2D", "2010 Jeep Liberty", 22000),
            new Auto("2DKSLU93K2KDIUSKR", "2007 Ford F150 XLT", 22500),
            new Auto("7JDUE736SJDMKIDHS", "2004 Cadillac DeVille", 11800),
            new Auto("0KS73HSMJFHCGEGS2", "2006 Saturn Ion 2", 6375),
            new Auto("111JDISLANEUS3203", "1970 Chevrolet Chevelle SS", 5400),
            new Auto("2K394DJSLIDJSN45K", "2002 Honda Civic", 2900),
            new Auto("LK45JMDNABBE4IWKE", "1994 Jaguar", 2330),
            new Auto("9OUEIWJQNSJRUE3J1", "2010 Dodge Nitro SXT", 22740),
            new Auto("66KD3849DJ7WY3HWS", "2000 Pontiac Firebird", -3782),
            new Auto("JJKW45NCBXVSLO3WS", "1999 Ford Taurus", 2120)
            };

            // Display autos
            Console.WriteLine("All autos:");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{"#",-5} {"VIN",-20} {"Make/Model", -30} {"Cost",15} {"Price", 15} {"Profit", 15}");
            Console.BackgroundColor = ConsoleColor.Black;
            DisplayCars(-1); // All cars

            Console.WriteLine("\nAutos with a list price at or below $10,000:");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{"#",-5} {"VIN",-20} {"Make/Model",-30} {"Cost",15} {"Price",15} {"Profit",15}");
            Console.BackgroundColor = ConsoleColor.Black;
            DisplayCars(10000); // Only if it matches


            // Method
            void DisplayCars(double x)
            {
                bool flag = false;
                if (x == -1)
                {
                    for (int i = 0; i < autos.Length; i++)
                    {
                        Console.WriteLine($"{i + 1 + ".",-5}{autos[i].Details()}");
                    }
                }else
                {                            int counter=1;

                    for (int i = 0; i < autos.Length; i++)
                    {
                        if (autos[i].ListPrice <= x)
                        {
                            flag = true;
                            Console.WriteLine($"{counter + ".", -5}{autos[i].Details()}");
                            counter++;
                        }
                    }
                    if (flag != true) // Was something found?
                        Console.WriteLine("No autos found matching search!"); // This only works with negative number since zero is the default for the negative cost.

                }
                            }

            Console.Write("\nPress any key to exit: ");
            Console.ReadKey(); // Exit
        }
    }
}

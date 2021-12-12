using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Bicycle("Bicycle", 60, 150),
                new PHEV("Chevy Volt", 60, 40, 39),
                new Auto("Cadillac", 60, 20)
            };

            // Display vehicles
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{"Name",-10}{"Hours",10}{"Gallons",10}{"Cost",10}");
            Console.BackgroundColor = ConsoleColor.Black;

            foreach (Vehicle v in vehicles)
            {
                Console.Write($"{v.Name,-10}{v.Hours,10:F}");
                if (v is Auto)
                {
                    Console.Write($"{((Auto)v).Gallons,10:F}{((Auto)v).Cost,10:C}");
                }

                Console.WriteLine(); // Goes to new line
            }

            // Exit
            Console.Write("\nPress any key to exit ");
            Console.ReadKey();
        }
    }
}

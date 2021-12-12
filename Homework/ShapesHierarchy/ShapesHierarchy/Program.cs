using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[] {
                new Circle("Circle", 5),
                new Cube("Cube", 5),
                new Square("Square", 5),
                new Sphere("Sphere", 5)
            };
        
            foreach(Shape s in shapes)
            {
                Console.BackgroundColor = ConsoleColor.Gray; // Start formatting
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine(s.ToString().ToUpper()); // Description

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black; // End formatting

                if(s is TwoDimensionalShape)
                {
                    Console.WriteLine($"Area: {((TwoDimensionalShape)s).Area:N2}\n");
                }
                else if (s is ThreeDimensionalShape)
                {
                    Console.WriteLine($"Area: {((ThreeDimensionalShape)s).Area:N2}");
                    Console.WriteLine($"Volume: {((ThreeDimensionalShape)s).Volume:N2}\n");
                }
            }

            // Exit
            Console.Write("Press any key to exit ");
            Console.ReadKey();
        }
    }
}

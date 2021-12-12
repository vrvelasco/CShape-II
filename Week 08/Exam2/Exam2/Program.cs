using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>()
            {
                new Auto("7JDUE736SJDMKIDHS", "Honda Civic", 11800),
                new Auto("3KFKLSO93MN4K3H2D", "Jeep Liberty", 22000),
                new Auto("2DKSLU93K2KDIUSKR", "Ford Taurus", 22500),
                new Auto("0KS73HSMJFHCGEGS2", "Saturn Ion 2", 6375),
                new Auto("111JDISLANEUS3203", "Chevrolet Chevelle SS", 5400),
                new Auto("2K394DJSLIDJSN45K", "Honda Civic", 2900),
                new Auto("LK45JMDNABBE4IWKE", "Jaguar", 2330),
                new Auto("9OUEIWJQNSJRUE3J1", "Dodge Nitro SXT", 22740),
                new Auto("66KD3849DJ7WY3HWS", "Honda Civic", -3782),
                new Auto("JJKW45NCBXVSLO3WS", "Ford Taurus", 2120)
            };


            /*
             *     PART I
             */

            PrintTitle("Distinct make/model");
            var distinctCar = (from d in autos
                               select d.MakeModel).Distinct();

            foreach (var c in distinctCar)
            {
                Console.WriteLine(c);
            }

            PrintTitle("\nAll autos having the the first make and model");

            var sameMakeModel = from s in autos
                                where s.MakeModel.Equals(distinctCar.First())
                                select s;

            Console.WriteLine($"{"VIN",-20}{"Make/Model",24}{"Cost",15:C}{"List",15:C}{"Profit",15:C}");
            Console.WriteLine($"{"-------------------",-20}{"------------------------",24}{"--------------",15:C}{"--------------",15:C}{"--------------",15:C}");

            double averageListPrice = 0.0;
            foreach (var s in sameMakeModel)
            {
                averageListPrice += s.List;
                Console.WriteLine($"{s.VIN, -20}{s.MakeModel,24}{s.Cost,15:C}{s.List,15:C}{s.Profit,15:C}");
            }

            Console.WriteLine($"\nNumber of {sameMakeModel.First().MakeModel} in stock: {sameMakeModel.Count()}" +
                $"\nAverage {sameMakeModel.First().MakeModel} list price: {averageListPrice/sameMakeModel.Count():C}");

            var listItem = sameMakeModel.Last();
            autos.Remove(listItem);
            autos.Insert(0, listItem);

            /*
             *     PART II
             */

            PrintTitle("\nAll autos before increasing margin");
            Console.WriteLine($"{"VIN",-20}{"Make/Model",24}{"Cost",15:C}{"List",15:C}{"Profit",15:C}");
            Console.WriteLine($"{"-------------------",-20}{"------------------------",24}{"--------------",15:C}{"--------------",15:C}{"--------------",15:C}");
            foreach (var s in autos)
            {
                averageListPrice += s.List;
                Console.WriteLine($"{s.VIN,-20}{s.MakeModel,24}{s.Cost,15:C}{s.List,15:C}{s.Profit,15:C}");
            }

            Auto.IncreaseMargin();

            PrintTitle("\nAll autos after increasing and before decreasing margin");
            Console.WriteLine($"{"VIN",-20}{"Make/Model",24}{"Cost",15:C}{"List",15:C}{"Profit",15:C}");
            Console.WriteLine($"{"-------------------",-20}{"------------------------",24}{"--------------",15:C}{"--------------",15:C}{"--------------",15:C}");
            foreach (var s in autos)
            {
                averageListPrice += s.List;
                Console.WriteLine($"{s.VIN,-20}{s.MakeModel,24}{s.Cost,15:C}{s.List,15:C}{s.Profit,15:C}");
            }

            Auto.DecreaseMargin();

            PrintTitle("\nAll autos after decreasing margin");
            Console.WriteLine($"{"VIN",-20}{"Make/Model",24}{"Cost",15:C}{"List",15:C}{"Profit",15:C}");
            Console.WriteLine($"{"-------------------",-20}{"------------------------",24}{"--------------",15:C}{"--------------",15:C}{"--------------",15:C}");
            foreach (var s in autos)
            {
                averageListPrice += s.List;
                Console.WriteLine($"{s.VIN,-20}{s.MakeModel,24}{s.Cost,15:C}{s.List,15:C}{s.Profit,15:C}");
            }


            // Methods
            void PrintTitle(string m)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(m);
                Console.BackgroundColor = ConsoleColor.Black;
            }

            // Exit
            Console.Write("\nPRESS ANY KEY TO EXIT: ");
            Console.ReadKey();
        }
    }
}

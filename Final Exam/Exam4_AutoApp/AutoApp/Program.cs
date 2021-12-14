using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Instantiate the data context at the top of method Main. The data context class name is
            // AutosEntities
            AutosEntities db = new AutosEntities();

            // 3) Show the set of distinct Make values from the Autos table.
            var distinctMake = db.Autos.Select(m => m.Make).Distinct();
            Console.WriteLine(" Distinct makes:\n");
            foreach (string m in distinctMake)
            {
                Console.WriteLine($" {m.ToString()}");
            }

            // 4) Use the ShowAutos method to display all autos in order by Year descending. 
            var allAutos = db.Autos.OrderByDescending(y => y.Year);
            ShowAutos("All autos:", allAutos);

            // 5) Assign three queries to the following three variables. Each query returns a subset of Auto
            // objects.
            var fords = db.Autos.Where(f => f.Make.ToLower().Equals("ford"));
            var fordsOlder = fords.Where(y => y.Year < 2000);
            var fordsOver10 = fords.Where(o => o.Cost > 10000M);

            // 6) Use the ShowAutos method to display the results of each of the queries: fords, fordsOlder,
            // fordsOver10.
            ShowAutos("All Fords:", fords);
            ShowAutos("Older Fords:", fordsOlder);
            ShowAutos("Fords Over $10,000:", fordsOver10);

            // 7) Use the fords query to find the sum of Cost for all Fords, and then display it.
            Console.WriteLine($"\n Sum of Cost of all Fords: {fords.Select(c => c.Cost).Sum():C}");

            // 8) Search for an auto with VIN 1234567890123456
            var search = db.Autos.Where(v => v.VIN.Equals("1234567890123456"));

            if (search.Any())
            {
                // If the search succeeds, remove the auto with VIN:1234567890123456 from the
                // database.
                db.Autos.Remove(search.FirstOrDefault());
                db.SaveChanges();
                MessageLine("\n Vehicle has been removed.", 'r');
            }
            else
            {
                // If the search fails, add a 2020 Ford Fusion with VIN:1234567890123456 and a cost of
                // $28,000 to the database.
                db.Autos.Add(new Auto()
                {
                    Year = 2000,
                    Make = "Ford",
                    Model = "Fusion",
                    VIN = "1234567890123456",
                    Cost = 28000M
                });
                db.SaveChanges();
                MessageLine("\n New vehicle was added.",'g');
            }

            // 9) After saving changes, use the fords query again to find the sum of Cost for all Fords, and then
            // display it.
            Console.WriteLine($"\n Sum of Cost of all Fords: {fords.Select(c => c.Cost).Sum():C}");

            MessageLine("\n Had fun learning this semester! Thank you!", 'b');

            // Exit
            Console.Write("\n Press any key to exit: ");
            Console.ReadKey();

            void ShowAutos(string title, IEnumerable<Auto> set)
            {
                Console.WriteLine($"\n {title}");
                Console.WriteLine($" {"Year",-5} {"MakeModel",-25} {"Cost",10} {"Price",10}");
                Console.WriteLine($" {"----",-5} {"---------",-25} {"----",10} {"-----",10}");
                foreach (var a in set)
                {
                    Console.WriteLine($" {a.Year,-5} {a.MakeModel,-25} {a.Cost,10:C} {a.Price,10:C}");
                }
            }

            void MessageLine(string m, char c)
            {
                if (c.Equals('r'))
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                else if (c.Equals('g'))
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                else
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                
                Console.WriteLine(m);
                
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }

    // 2) Extend the Auto entity class with a partial class that adds the following properties:
    partial class Auto
    {
        // • Price - Cost after a 10% markup
        public decimal Price { get => Cost * 1.1M; }

        // • MakeModel - combine Make and Model in one string (as in “Ford/Ranger”). 
        public string MakeModel { get => $"{Make}/{Model}"; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Publication aBook = new Book("Starting out with C#", 2017, "Gaddis", "Computer Science");
            Publication aMag = new Magazine("Wired", 2018, "June", 1);

            aMag.Read = true;
            aBook.Read = true;

            Console.WriteLine($"{aMag.Title} (Published: {((Magazine)aMag).PubDate})");
            Console.WriteLine(aMag.GetInfo());

            Console.WriteLine($"{aBook.Title} (Published: {aBook.Year})");
            Console.WriteLine(aBook.GetInfo());


            Console.ReadKey();
        }
    }
}

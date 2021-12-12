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

            if (aMag is Magazine)
            {
                Console.WriteLine($"{aMag.Title} (Published: {((Magazine)aMag).PubDate})");
            }
            else
            {
                Console.WriteLine($"{aMag.Title}");
            }

            //Console.WriteLine($"{aMag.Title} (Published: {((Magazine)aMag).PubDate})");
            Console.WriteLine(aMag.GetInfo());
            Console.WriteLine($"{aBook.Title} (Published: {aBook.Year})");
            Console.WriteLine(aBook.GetInfo());

            List<Publication> pubs = new List<Publication>() {
            new Book("Starting out with C#", 2017, "Gaddis", "Computer Science"),
            new Magazine("Wired", 2011, "June", 1),
            new Book("Visual C#: How to Program", 2017, "Deitel", "Computer Science"),
            new Magazine("PC Magazine", 2015, "September", 9) };

            foreach(Publication p in pubs)
            {
                Console.WriteLine(p.GetInfo());
            }

            Console.ReadKey();
        }
    }
}

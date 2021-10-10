using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoices = {
            new Invoice(83, "Electric sander", 7, 57.98M),
            new Invoice(24, "Power saw", 18, 99.99M),
            new Invoice(7, "Sledge hammer", 11, 21.50M),
            new Invoice(77, "Hammer", 76, 11.99M),
            new Invoice(39, "Lawn mower", 3, 79.50M),
            new Invoice(68, "Screwdriver", 106, 6.99M),
            new Invoice(56, "Jig saw", 21, 11.00M),
            new Invoice(3, "Wrench", 34, 7.50M)
            };

            // a) Use LINQ to sort the Invoice objects by PartDescription
            PrintTitle("Sort by part description".ToUpper()); 
            var partDes = from p in invoices
                          orderby p.PartDescription
                          select p;
            PrintInvoice(partDes);


            // b) Use LINQ to sort the Invoice objects by price
            PrintTitle("Sort by price".ToUpper()); 
            var partPrice = from p in invoices
                            orderby p.Price
                            select p;
            PrintInvoice(partPrice);


            // c) Use LINQ to select the PartDescription and Quantity and sort the results by Quantity
            PrintTitle("Part description and quantity sorted by quanity".ToUpper()); 
            var partDesQuantity = from p in invoices
                                  orderby p.Quantity
                                  select new { First = p.PartDescription, Second = p.Quantity };
            PrintColumns("Part Description", "Quantity");

            foreach (var v in partDesQuantity)
            {
                Console.WriteLine($"{v.First,-20}{v.Second,-8}");
            }

            ResetConsoleColors();


            /* d) Use LINQ to select from each Invoice the PartDescription and the value of the Invoice 
                * (i.e., Quantity * Price). Name the calculated column InvoiceTotal. Order the results by Inoice
                * value. [Hint: Use let to store the resulte of Quantity * Price in a new range variable total.]*/
            PrintTitle("Part description and value sorted by total".ToUpper()); 
            var partValue = from p in invoices
                            let InvoiceTotal = p.Quantity * p.Price
                            orderby InvoiceTotal
                            select new { First = p.PartDescription, Second = InvoiceTotal };
            PrintColumns("Part Description", "Value");

            foreach (var v in partValue)
            {
                Console.WriteLine($"{v.First,-20}{v.Second,-8}");
            }

            ResetConsoleColors();

            // e) Using the results of the LINQ query in part (d), select the InvoiceTotals in the range $200 to $500.
            PrintTitle("Invoice total between $200 and $500".ToUpper()); 
            PrintColumns("Part Description", "Value");

            foreach (var v in partValue)
            {
                if (v.Second >= 200 && v.Second <= 500)
                    Console.WriteLine($"{v.First,-20}{v.Second,-8}");
            }

            ResetConsoleColors();
        

        // Method

        void PrintInvoice(IEnumerable<Invoice> parts)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{"Part Number",-15}{"Part Description",-20}{"Quantity",-12}{"Price",-5}");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            foreach (var p in parts)
            {
                Console.WriteLine($"{p.PartNumber,-15}{p.PartDescription,-20}{p.Quantity,-12}{p.Price,-5}");
            }

            ResetConsoleColors();
        }

            void PrintTitle(string t)
            {
                Console.WriteLine($"\n{t}\n");
                Thread.Sleep(1000);
            }

        void PrintColumns(string f, string s)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{f,-20}{s,-8}");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        void ResetConsoleColors()
        {
            // Reset colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

            // Exit
            Console.Write("\nPress any key to exit".ToUpper());
            Console.ReadKey();
        }
}
}

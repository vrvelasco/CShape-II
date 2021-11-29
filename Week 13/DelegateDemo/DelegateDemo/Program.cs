using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        public delegate bool IsTest(int number);

        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine($"Is {num} over 5?: {IsOver5(num)}");
            Console.WriteLine($"Is {num} an even number?: {IsEven(num)}");
            Console.WriteLine($"Is {num} an odd number?: {IsOdd(num)}");

            int[] numbers = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };
            DisplayList("All numbers: ", numbers);

            // Implicitly typed expression lambdas
            //DisplayList("Even Numbers: ", Filter(numbers, IsEven)); // Using delegate
            DisplayList("Even Numbers: ", Filter(numbers, n => n % 2 == 0)); // Using Lambda
            DisplayList("Odd Numbers: ", Filter(numbers, IsOdd));
            //DisplayList("Numbers over 5: ", Filter(numbers, IsOver5)); // Using delegate
            //DisplayList("Numbers over 5: ", Filter(numbers, n => n > 5)); // Using Lambda

            // Multi-line statement lambda
            //DisplayList("Numbers over 5: ", Filter(numbers, n => { bool x = n > 5; return x; }));

            // Single statement lambda
            //DisplayList("Numbers over 5: ", Filter(numbers, n => { return n > 5; }));

            // Explicitly typed expression lambda
            DisplayList("Numbers over 5: ", Filter(numbers, (int n) => n > 5));

            var filtered = numbers.Where(n => n > 4);
            DisplayList("Filtered over 4 using LINQ method syntax: ", filtered);

            var ordered = numbers.OrderBy(n => n);
            DisplayList("Ordered using LINQ method syntax: ", ordered);

            var orderedDescending = numbers.OrderByDescending(n => n);
            DisplayList("Ordered descending using LINQ method syntax: ", orderedDescending);

            var selected = numbers.Select(n => n * 2);
            DisplayList("Doubled using LINQ method syntax: ", selected);

            Console.WriteLine($"Sum using LINQ method: {numbers.Sum()}");
            Console.WriteLine($"Sum over 4 using LINQ method: {numbers.Where(n => n > 4).Sum()}");
            Console.WriteLine($"Sum doubled using LINQ method: {numbers.Sum(n => n * 2)}");
            //Console.WriteLine($"Count of numbers over 4 using LINQ method: {numbers.Where(n => n > 4).Count()}"); // Longer way
            Console.WriteLine($"Count of numbers over 4 using LINQ method: {numbers.Count(n => n > 4)}"); // Shorter way

            DisplayList("Over 4, doubled, reversed order: ", 
                numbers.Where(n => n > 4) // Filter
                .Select(n => n *2) // Double
                .OrderByDescending(n => n) // Ordering in descending order
                .Distinct() // Remove duplicates
                );

            Console.ReadKey();

            // Methods
            void DisplayList(string description, IEnumerable<int> list)
            {
                Console.Write(description);
                foreach (var item in list)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            //List<int> FilterEven(int[] intArray)
            //{
            //    var result = new List<int>();

            //    foreach (int item in intArray)
            //    {
            //        if (IsEven(item))
            //        {
            //            result.Add(item);
            //        }
            //    }

            //    return result;
            //}

            //List<int> FilterOdd(int[] intArray)
            //{
            //    var result = new List<int>();

            //    foreach (int item in intArray)
            //    {
            //        if (IsOdd(item))
            //        {
            //            result.Add(item);
            //        }
            //    }

            //    return result;
            //}

            //List<int> FilterOver5(int[] intArray)
            //{
            //    var result = new List<int>();

            //    foreach (int item in intArray)
            //    {
            //        if (IsOver5(item))
            //        {
            //            result.Add(item);
            //        }
            //    }

            //    return result;
            //}

            List<int> Filter(int[] intArray, IsTest test) // Custom
            {
                var result = new List<int>();

                foreach (int item in intArray)
                {
                    if (test(item))
                    {
                        result.Add(item);
                    }
                }

                return result;
            }

            //List<int> Filter(int[] intArray, Func<int, bool> test) // Built in delegate
            //{
            //    var result = new List<int>();

            //    foreach (int item in intArray)
            //    {
            //        if (test(item))
            //        {
            //            result.Add(item);
            //        }
            //    }

            //    return result;
            //}

            bool IsOver5(int n) => n > 5;
            bool IsEven(int n) => n % 2 == 0;
            bool IsOdd(int n) => n % 2 == 1;



            //bool IsOver5(int n)
            //{
            //    bool x = n > 5;
            //    return x;
            //}
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 6 };

            //foreach (int v in values)
            //{
            //    if (v > 4)
            //    {
            //        Console.WriteLine(v.ToString());
            //    }
            //}

            Console.WriteLine("Over 4:");
            var filtered = from v in values
                           where v > 4
                           select v;
            ShowNumbers(filtered);

            Console.WriteLine("\nSorted:");
            var sorted = from v in values
                         orderby v
                         select v;
            ShowNumbers(sorted);

            Console.WriteLine("\nFilter and sort -  one query:");
            var filterSort = from v in values
                             where v > 4
                             orderby v
                             select v;
            ShowNumbers(filterSort);

            Console.WriteLine("\nFilter and sort -  two queries:");
            var filterSort2 = from v in filtered
                              orderby v
                              select v;
            ShowNumbers(filterSort2);

            Console.WriteLine("\nOver 4 - Doubled:");
            var doubled = from v in filtered
                          select v * 2;
            ShowNumbers(doubled);

            Student[] students = new Student[] {
                new Student("Mary", "Blue"),
                new Student("Becky", "Blue"),
                new Student("Simon", "Smith", 15),
                new Student("Fanny", "Fargo"),
                new Student("Pete", "Smith", 9),
                new Student("Bill", "Bailey"),
                new Student("John", "Long"),
                new Student("Van", "Hill", 36),
                new Student("Cindy", "Jones"),
                new Student("Marcy", "Michaels", 18)
            };

            ShowStudents("All students:", students);

            var stus = from s in students
                       where s.TotalCredits > 10
                       select s;
            ShowStudents("Students with total over 10:", stus);

            var stus2 = from s in students
                        orderby s.StudentLastName, s.StudentFirstName
                        select s;
            ShowStudents("Students ordered by last name:", stus2);

            Console.WriteLine("\nStudent names only:");
            var studentNames = from s in students
                               select s.FullName;
            ShowStrings(studentNames);

            Console.WriteLine("\nStudent names and classes:");
            var studentNamesClasses = from s in students
                                      let classes = s.TotalCredits / 3
                                      select new { Full = s.FullName, Classes = classes };
            foreach (var v in studentNamesClasses)
            {
                Console.WriteLine(v.Full + "\t" + v.Classes);
            }

            int c1 = students.Count();
            Console.WriteLine($"\nNumber of students: {c1}");

            int c2 = (from s in studentNamesClasses where s.Classes > 0 select s).Count();
            Console.WriteLine($"\nNumber of students with classes: {c2}");

            int c3 = (from s in students select s.StudentLastName).Distinct().Count();
            Console.WriteLine($"\nNumber of distinct last name: {c2}");

            string x = (from s in students select s.StudentLastName).Distinct().First();
            Console.WriteLine($"\nFirst distinct students last name: {x}");


            Console.ReadKey();

            void ShowNumbers(IEnumerable<int> set)
            {
                foreach (int v in set)
                    Console.WriteLine(v.ToString());
            }

            void ShowStrings(IEnumerable<string> set)
            {
                foreach (string v in set)
                    Console.WriteLine(v);
            }

            void ShowStudents(string title, IEnumerable<Student> set)
            {
                Console.WriteLine($"\n{title}");
                Console.WriteLine($"{"Student",-18}{"Current",-8}{"Total",-8}");
                Console.WriteLine($"{"-------",-18}{"-------",-8}{"-----",-8}");

                foreach (Student s in set)
                    Console.WriteLine(s.ShowStudent());
            }

        }
    }
}

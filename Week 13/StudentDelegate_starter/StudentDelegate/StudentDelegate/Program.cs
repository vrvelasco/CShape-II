using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDelegate
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
                new Student("Biff","Arfus"),
                new Student("Simon", "Smith", 15),
                new Student("Fanny", "Fargo"),
                new Student("Pete", "Smith", 9),
                new Student("Bill", "Bailey"),
                new Student("John", "Long"),
                new Student("Van", "Hill", 36),
                new Student("Cindy", "Jones"),
                new Student("Sean", "Childs"),
                new Student("Marcy", "Michaels", 18)
            };

            //Enroll students in current semester
            students[2].AddCredits(16);
            students[5].AddCredits(18);
            students[6].AddCredits(15);

            ShowStudents("All students: ", students.ToList());
           
            var ordered = students.OrderBy(s => s.FullName);
            ShowStudents("Students in order by full name: ", ordered.ToList());

            var orderedSecondChar = students.OrderBy(s => s.FullName.Substring(1));
            ShowStudents("Students in order by second character in full name: ", orderedSecondChar.ToList());


            //Full-time students
            //var fulltime = from s in students
            //               where s.CurrentCredits >= 12
            //               select s;

            var fulltime = students.Where(s => s.CurrentCredits >= 12);

            ShowStudents("Full-time students", fulltime.ToList());

            //Count
            //int intCntFT = fulltime.Count();
            int intCntFT = students.Count(s => s.CurrentCredits >= 12);

            Console.Write("\nNumber of FT students: ");
            Console.WriteLine(intCntFT.ToString());

            //Sum of current fulltime credits
            //int intSumCurFT = (from s in fulltime
            //               select s.CurrentCredits).Sum();

            int intSumCurFT = fulltime.Select(s => s.CurrentCredits).Sum();
            Console.Write("\nSum of FT current credits: ");
            Console.WriteLine(intSumCurFT.ToString());

            var ftfs = students
                .Where(s => s.CurrentCredits >= 12 && s.TotalCredits < 12)
                .Select(s => new { s.FullName, Classes = s.CurrentCredits / 3 }); // Anonymous type

            Console.WriteLine("\nFT first semester students");
            foreach(var s in ftfs)
            {
                Console.WriteLine($"{s.FullName} has {s.Classes} classess.");
            }

            Console.ReadKey();

            void ShowStudents(string title, List<Student> set)
            {
                Console.WriteLine("");
                Console.WriteLine(title);
                Console.WriteLine("#   Student Name      Current     Total");
                Console.WriteLine("--- -------------- ---------- ---------");
                for (int ii = 0; ii < set.Count(); ii++)
                {
                    Console.WriteLine($"{(ii + 1) + ".",-3} {set[ii].ShowStudent()}");
                }
            }
        }
    }
}

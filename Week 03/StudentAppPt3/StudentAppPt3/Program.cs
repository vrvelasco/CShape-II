using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppPt3
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine($"{"Name",-15}{"Current",-10}{"Total",-5}");
            Console.WriteLine($"{"-----",-15}{"-------",-10}{"-----",-5}");

            students[2].AddCredits(16);
            students[5].AddCredits(18);
            students[6].AddCredits(15);



            int intCnt = 0; // Number of students
            int intSumCurrent = 0; // Sum of all current credits

            foreach (Student s in students)
            {
                if (s.CurrentCredits >= 12)
                {
                    Console.WriteLine(s.ShowStudent());
                    intCnt++;
                    intSumCurrent += s.CurrentCredits;
                }
            }

            Console.Write("\nNumber of FT students: ");
            Console.WriteLine(intCnt.ToString());

            Console.Write("\nSum of FT current credits: ");
            Console.WriteLine(intSumCurrent.ToString());

            Console.Write("\nAverage FT current credits: ");
            Console.WriteLine((intSumCurrent / (double)intCnt).ToString());

            string strName = "ONG";
            Console.WriteLine("\nSearching for: " + strName);

            Student stu = null; // Flag variable

            //foreach (var s in students)
            //{
            //    if (s.StudentLastName == strName)
            //    {
            //        stu = s;
            //        break;
            //    }
            //}

            int i; // Counter

            for (i = 0; i < students.Count(); i++)
            {
                //if (students[i].StudentLastName.ToUpper().IndexOf(strName.ToUpper(), 0) >= 0)
                if (students[i].StudentLastName.ToUpper().Contains(strName.ToUpper()))
                {
                    stu = students[i];
                    break;
                }
            }

            if (stu != null)
            {
                Console.WriteLine("Found: " + stu.FullName + " at index " + i);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.ReadKey();
        }

    }
}
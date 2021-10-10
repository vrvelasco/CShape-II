using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp_console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student[] students = new Student[] {
            //    new Student("Mary", "Blue"),
            //    new Student("Becky", "Blue"),
            //    new Student("Simon", "Smith", 15),
            //    new Student("Fanny", "Fargo"),
            //    new Student("Pete", "Smith", 9),
            //    new Student("Bill", "Bailey"),
            //    new Student("John", "Long"),
            //    new Student("Van", "Hill", 36),
            //    new Student("Cindy", "Jones"),
            //    new Student("Marcy", "Michaels", 18)
            //};

            List<Student> students = new List<Student>() {
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

            //students.Add(new Student("Mary", "Blue"));
            //students.Add(new Student("Simon", "Smith", 15));
            //students.Add(new Student("Fanny", "Fargo"));
            //students.Add(new Student("Pete", "Smith", 9));
            //students.Add(new Student("Bill", "Bailey"));
            //students.Add(new Student("John", "Long"));
            //students.Add(new Student("Van", "Hill", 36));
            //students.Add(new Student("Cindy", "Jones"));
            //students.Add(new Student("Sean", "Childs"));
            //students.Add(new Student("Marcy", "Michaels", 18));

            students[2].AddCredits(16);
            students[5].AddCredits(18);
            students[6].AddCredits(15);

            //Show all students
            ShowStudents("All students", students);
            //Console.Write("\nAll students:\n");
            //foreach (var s in students)
            //{
            //    Console.WriteLine(s.ShowStudent());
            //}

            //Aggregates
            int cntFT = 0;   //number of FT students
            int sumFT = 0;  //sum of all FT current credits

            var fullTime = from s in students
                           where s.CurrentCredits >= 12 // Full time student
                           select s;

            ShowStudents("Full-time students", fullTime);

            cntFT = fullTime.Count();
            sumFT = (from s in fullTime select s.CurrentCredits).Sum();

            //Console.Write("\nFull-time students:\n");
            //foreach (var s in students)
            //{
            //    if (s.CurrentCredits >= 12)
            //    {
            //        cntFT++;
            //        sumFT += s.CurrentCredits;
            //        Console.WriteLine(s.ShowStudent());
            //    }
            //}

            Console.Write("\nNumber of FT students: ");
            Console.WriteLine(cntFT.ToString());
            Console.Write("\nSum of FT current credits: ");
            Console.WriteLine(sumFT.ToString());
            Console.Write("\nAverage FT current credits: ");
            if (fullTime.Any())
            {
                double avgFT = (from s in fullTime select s.CurrentCredits).Average();
                Console.WriteLine((sumFT / cntFT).ToString());
            }
            else
            {
                Console.WriteLine("Divide by zero error");
            }

            //Sequential Search
            Student stu = null; //flag 
            string strName = "j";
            int i;

            //Console.WriteLine("\nSearching for: " + strName);

            //for (i = 0; i < students.Count(); i++)
            //{
            //    //if (students[i].StudentLastName.ToLower().IndexOf(strName.ToLower(),0) >= 0)
            //    if (students[i].StudentLastName.ToLower().Contains(strName.ToLower()))
            //    {
            //        stu = students[i];
            //        break;
            //    }

            //}

            var matches = from s in students
                          where s.FullName.ToLower().Contains(strName.ToLower())
                          select s;

            stu = matches.FirstOrDefault(); // Returns 'null' if not found.
            i = students.IndexOf(stu);

            if (matches.Any())
            {
                Console.WriteLine("Found " + stu.FullName + " at index " + i);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            students.Insert(0, new Student("Mary", "Arfus"));
            ShowStudents("Students after inserting at the beginning", students);

            students.Add(new Student() { StudentFirstName = "Tim", CurrentCredits = 10 });
                        ShowStudents("Students after adding one with 10 credits", students);

            students.Remove(stu);
            ShowStudents($"Students after removing {stu.FullName}", students);

            students.RemoveAt(5);
            ShowStudents($"Students after removing 6th student", students);

            foreach(Student s in students)
            {
                s.AddCredits(18);
            }
            ShowStudents($"Students after adding 18 credits", students);

            Student.maxCredits = 21;

            foreach (Student s in students)
            {
                s.AddCredits(3);
            }
            ShowStudents($"Students after raising max and adding another 3 credits", students);

            Console.ReadKey();

            void ShowStudents(string title, IEnumerable<Student> set)
            {
                Console.WriteLine();
                Console.WriteLine(title);
                Console.WriteLine($"{"Student",-22}{"Current",-8}{"Total",-8}");
                Console.WriteLine($"{"-------",-22}{"-------",-8}{"-----",-8}");

                var stus = set.ToArray(); // Convert to array to get indexes.

                for (int j = 0; j < stus.Count(); j++)
                {
                    Console.WriteLine($"{j + 1 + ".",-3} {stus[j].ShowStudent()}");
                }
            }
        }
    }
}

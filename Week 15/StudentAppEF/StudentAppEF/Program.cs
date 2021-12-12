using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppEF
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsEntities db = new StudentsEntities();
            var students = db.students; // No need to rename

            //List<Student> students = new List<Student>
            //{
            //    new Student("Biff","Arfus"),
            //    new Student("Simon", "Smith", 15),
            //    new Student("Fanny", "Fargo"),
            //    new Student("Pete", "Smith", 9),
            //    new Student("Bill", "Bailey"),
            //    new Student("John", "Long"),
            //    new Student("Van", "Hill", 36),
            //    new Student("Cindy", "Jones"),
            //    new Student("Sean", "Childs"),
            //    new Student("Marcy", "Michaels", 18)
            //};

            //Enroll students in current semester
            //students[2].AddCredits(16);
            //students[5].AddCredits(18);
            //students[6].AddCredits(15);

            ShowStudents("All students: ", students.ToList());


            //Full-time students
            var fulltime = students.Where(s => s.CurrentCredits >= 12);

            ShowStudents("Full-time students", fulltime.ToList());

            //Count
            int intCntFT = students.Count(s => s.CurrentCredits >= 12);
            Console.Write("\nNumber of FT students: ");
            Console.WriteLine(intCntFT.ToString());

            //Sum of current fulltime credits
            int intSumCurFT = fulltime.Select(s => s.CurrentCredits).Sum();
            Console.Write("\nSum of FT current credits: ");
            Console.WriteLine(intSumCurFT.ToString());

            //average full time current credits
            if (fulltime.Any())
                Console.WriteLine("\nAverage FT current credits: " + fulltime.Select(s => s.CurrentCredits).Average().ToString());
            else
                Console.WriteLine("No FT students");

            //find student names containing string ("j")
            var match = students.ToList()
                .Where(s => s.FullName.ToLower()
                .Contains("j"));

            student stu = match.FirstOrDefault();
            int i = students.ToList().IndexOf(stu);


            if (match.Any())
            {
                Console.WriteLine("Found " + stu.FullName + " at index " + i);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            //stu.AddCredits();

            ShowStudents($"Student names containing 'j'", match.ToList());

            //students.Where(s => s.Id == 8).FirstOrDefault().AddCredits(12);

            //students.Add(new student()
            //{ // Add myself
            //    StudentFirstName = "Victor",
            //    StudentLastName = "Velasco",
            //    CurrentCredits = 12,
            //    TotalCredits = 0
            //});

            //students.Remove(students.Where(s => s.StudentLastName == "Velasco")
            //    .FirstOrDefault());

            db.SaveChanges();

            ShowStudents("Full-time students", fulltime.ToList());

            Console.ReadKey();

            void ShowStudents(string title, List<student> set)
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
        partial class student
        {
            public string FullName
            {
                get => $"{StudentFirstName} {StudentLastName}";
            }
        public void AddCredits()
        {
            CurrentCredits += 3;
        }

        public void AddCredits(int newCredits)
        {
            CurrentCredits += newCredits;
        }

        public string ShowStudent() => $"{FullName,-15}{CurrentCredits,10}{TotalCredits,10}";
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    class Course
    {
        public static int EnrollMax { get; set; }

        public string CourseName { get; set; }
        public string CatalogNumber { get; set; }
        public int Credits { get; set; }

        public List<Student> StudentsInCourse { get; set; }

        static Course()
        {
            EnrollMax = 8;
        }
        
        public Course(string name, string catNum, int credits)
        {
            StudentsInCourse = new List<Student>();
            CatalogNumber = catNum;
            CourseName = name;
            Credits = credits;
        }

        public void EnrollStudent(Student stu)
        {
            try
            {
                if (StudentsInCourse.Count < EnrollMax)
                {
                    if (!StudentsInCourse.Contains(stu))
                    {
                        StudentsInCourse.Add(stu);
                        stu.AddCredits(Credits);
                    }
                    else
                    {
                        Console.WriteLine($"Duplicate enrollment attempted. {stu.FullName} already enrolled in {CatalogNumber}");
                    }
                }
                else
                {
                    Console.WriteLine($"Course is full! {stu.FullName} was not enrolled in {CatalogNumber}");
                }
            }
            catch
            {
                Console.WriteLine($"Maximum credits exceeded! {stu.FullName} was not enrolled in {CatalogNumber}");

            }
        }

        public void ShowRoster()
        {
            Console.WriteLine("");
            Console.Write($"Roster for {CatalogNumber} ({CourseName}) with {StudentsInCourse.Count()} students");
            Console.WriteLine("\n#   Student Name      Current     Total");
            Console.WriteLine("--- -------------- ---------- ---------");
            for (int s = 0; s < StudentsInCourse.Count(); s++)
            {
                Console.WriteLine($"{(s + 1) + ".",-3} {StudentsInCourse[s].ShowStudent()}");
            }
        }

        public string ShowCourse()
        {
            return $"{CourseName,-18}{Credits,10}{StudentsInCourse.Count,10}";
        }

        public void DropStudent(Student stu)
        {
            StudentsInCourse.Remove(stu);
            stu.AddCredits(-Credits);
        }
    }
}

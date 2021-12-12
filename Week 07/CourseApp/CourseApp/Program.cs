using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
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

            List<Course> courses = new List<Course>()
            {
                new Course("C# Programming II","CIS262",3),
                new Course("Basic OS","CIS125",1),
                new Course("Database Design","CIS266",3),
                new Course("PowerShell","CIS178",3),
                new Course("ASP .NET","CIS264",3),
                new Course("Intro to IT","CIS185",3),
                new Course("SQL","CIS275",3),
            };

            courses[0].EnrollStudent(students[0]);
            courses[0].EnrollStudent(students[0]);
            courses[0].EnrollStudent(students[1]);
            courses[0].EnrollStudent(students[2]);
            courses[0].EnrollStudent(students[3]);
            courses[0].EnrollStudent(students[4]);
            courses[0].EnrollStudent(students[5]);
            courses[0].EnrollStudent(students[6]);
            courses[0].EnrollStudent(students[7]);
            courses[0].EnrollStudent(students[8]);
            courses[0].EnrollStudent(students[9]);

            courses[1].EnrollStudent(students[4]);
            courses[2].EnrollStudent(students[4]);
            courses[3].EnrollStudent(students[4]);
            //courses[4].EnrollStudent(students[4]);
            //courses[5].EnrollStudent(students[4]);
            //courses[6].EnrollStudent(students[4]);

            courses[0].ShowRoster();

            Console.WriteLine($"\n{"Course Name",-18}{"Credits",10}{"Count",10}");
            Console.WriteLine($"{"-----------",-18}{"-------",10}{"-----",10}");

            foreach (var c in courses)
            {
                Console.WriteLine(c.ShowCourse());
            }

            var made = from c in courses
                       where c.StudentsInCourse.Count() > 0
                       select c;

            Console.WriteLine("\nCourses with students enrolled");
            Console.WriteLine($"{"Course Name",-18}{"Credits",10}{"Count",10}");
            Console.WriteLine($"{"-----------",-18}{"-------",10}{"-----",10}");

            foreach (var c in made)
            {
                Console.WriteLine(c.ShowCourse());
            }

            var over50 = from c in courses
                         let percent = c.StudentsInCourse.Count / (double)Course.EnrollMax
                         where percent > .5
                         select c;

            Console.WriteLine("\nCourses with over 50% enrolled");
            Console.WriteLine($"{"Course Name",-18}{"Credits",10}{"Count",10}");
            Console.WriteLine($"{"-----------",-18}{"-------",10}{"-----",10}");

            foreach (var c in over50)
            {
                Console.WriteLine(c.ShowCourse());
            }

            courses[0].ShowRoster();
            courses[0].DropStudent(students[0]);
            courses[0].DropStudent(students[0]);
            courses[0].ShowRoster();
            Console.WriteLine(students[0].ShowStudent());


            Console.ReadKey();
        }
    }
}

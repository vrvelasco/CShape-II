using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
            new Student("Mary", "Blue", 10),
            new Student("Becky", "Blue"),
            new Student("Simon", "Smith", 15),
            new Student("Fanny", "Fargo"),
            new Student("Pete", "Smith", 9),
            new Student("Bill", "Bailey"),
            new Student("John", "Long"),
            new Student("Van", "Hill", 36),
            new Student("Cindy", "Jones"),
            new Student("Marcy", "Michaels", 18) };

            /* Console.Write("What is your name: ");
             * string name = Console.ReadLine();
             * Console.WriteLine("Hello, " + name); */

            //Student stu = new Student("Mary", "Blue", 10);

            //Console.WriteLine(stu.StudentFullName + " now has " + stu.CurrentCredits + " credits");
            Console.WriteLine(students[0].ShowStudent());
            students[0].AddCredits();
            Console.WriteLine(students[0].ShowStudent());
            students[0].AddCredits(1);
            Console.WriteLine(students[0].ShowStudent());

            //Console.WriteLine(stu.StudentFullName + " now has " + stu.CurrentCredits + " credits");
            students[0].ResetCredits();
            Console.WriteLine(students[0].ShowStudent());

            ShowAllStudents();

            foreach (Student s in students)
            {
                s.AddCredits();
            }

            ShowAllStudents();

            foreach (Student s in students)
            {
                s.ResetCredits();
            }

            ShowAllStudents();

            Console.WriteLine("");
            Console.WriteLine("Press a key");
            Console.ReadKey();

            // Local method
            void ShowAllStudents()
            {
                Console.WriteLine("Name            Current Total");
                Console.WriteLine("--------------- ------- -----");

                foreach (Student s in students)
                {
                    Console.WriteLine(s.ShowStudent());
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolleeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPaysTuition> enrollees = new List<IPaysTuition>()
            {
                // Traditional Student
                new Student("Mary", "Blue"),
                new Student("Becky", "Blue"),
                new Student("Simon", "Smith", 15),
                new Student("Fanny", "Fargo"),
                new Student("Pete", "Smith", 9),
                new Student("Bill", "Bailey"),
                new Student("John", "Long"),
                new Student("Van", "Hill", 36),
                new Student("Cindy", "Jones"),
                new Student("Marcy", "Michaels", 18),
                // Faculty
                new Faculty("Lawrence", "Appelbaum"),
                new Faculty("Beth", "Burns"),
                new Faculty("Karla", "Brown"),
                // Com. Ed. Student
                //new ComEdStudent("Zibin", "Xu"),
                //new ComEdStudent("Cailing", "Xu")
            };
   
            foreach(SWICEnrollee s in enrollees)
            {
                s.AddCredits(3);
            }

            ShowEnrollees();

            Console.ReadKey();

            void ShowEnrollees()
            {
                Console.WriteLine("");
                Console.WriteLine("Enrollee Name          Tuition");
                Console.WriteLine("------------------- ----------");
                foreach (IPaysTuition s in enrollees)
                {
                    Console.WriteLine($"{s.FullName,-20}{s.Tuition,10:c}");
                }
            }
        }

    }
}

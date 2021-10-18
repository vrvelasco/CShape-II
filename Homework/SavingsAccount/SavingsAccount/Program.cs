using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start two savings accounts
            SavingsAccount saver1 = new SavingsAccount(2000);
            SavingsAccount saver2 = new SavingsAccount(3000);

            AccountTitle("Interest rate at 4%");
            DisplayAccounts(4); // Interest rate 4%

            AccountTitle("After increasing rate to 5%");
            DisplayAccounts(5); // Interest rate 5%

            void IncreaseRate(double r)
            {
                SavingsAccount.AnnualInterestRate = r;
            }

            void DisplayAccounts(int r)
            {
                /*
                 *     Account 1
                 */
                Console.WriteLine($"Savings account #1:\n\tPrevious Balance: {saver1.SavingsBalance,-10:C}");
                
                // Increase rate
                IncreaseRate(r);
                saver1.CalculateMonthlyInterest(); // Calculate interest

                Console.WriteLine($"\tInterest Accrued: {saver1.AccruedInterest,-10:C}" +
                $"\n\tCurrent Balance:  {saver1.SavingsBalance,-10:C}");
                
                /* 
                 *     Account 2
                 */
                Console.WriteLine($"\nSavings account #2:\n\tPrevious Balance: {saver2.SavingsBalance,-10:C}");

                // Increase rate
                IncreaseRate(r);
                saver2.CalculateMonthlyInterest(); // Calculate interest

                Console.WriteLine($"\tInterest Accrued: {saver2.AccruedInterest,-10:C}" +
                $"\n\tCurrent Balance:  {saver2.SavingsBalance,-10:C}");
            }

            void AccountTitle(string m)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\n{m}\n".ToUpper());
                Console.BackgroundColor = ConsoleColor.Black;
            }

            // Exit
            Console.Write("\nPRESS ANY KEY TO EXIT: ");
            Console.ReadKey();
        }
    }
}

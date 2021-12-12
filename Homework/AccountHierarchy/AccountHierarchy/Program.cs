using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal D = 500.0M, W = 450.0M; // For easy testing.

            // Start accounts
            Account myAccount = new Account(5000M);
            CheckingAccount myChecking = new CheckingAccount(10000M, 1);
            SavingsAccount mySavings = new SavingsAccount(15000M, 2);


            // Display balance
            Console.WriteLine($"Generic Account:");
            Console.WriteLine($"\tBalance: {myAccount.Balance:C}");
            myAccount.Credit(D); // Deposit
            Console.WriteLine($"\tBalance after {D:C} deposit: {myAccount.Balance:C}");
            try
            {
                myAccount.Debit(W); // Withdrawl
                Console.WriteLine($"\tBalance after {W:C} withdrawl: {myAccount.Balance:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t*** WITHDRAWAL FAILED: {ex.Message} ***");
            }

            Console.WriteLine($"\nChecking Account:");
            Console.WriteLine($"\tStarting Balance: {myChecking.Balance:C}");
            myChecking.Credit(D); // Deposit
            Console.WriteLine($"\tBalance after {D:C} deposit and a fee of {myChecking.Fee:C}: {myChecking.Balance:C}");
            try
            {
                myChecking.Debit(W); // Withdrawl
                Console.WriteLine($"\tStarting Balance after {W:C} withdrawl and a fee of {myChecking.Fee:C}: {myChecking.Balance:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t*** WITHDRAWAL FAILED: {ex.Message} ***");
            }

            Console.WriteLine($"\nSavings Account");
            Console.WriteLine($"\tStarting Balance: {mySavings.Balance:C}");
            mySavings.Credit(D); // Deposit
            Console.WriteLine($"\tBalance after {D:C} deposit: {mySavings.Balance:C}");
            try
            {
                mySavings.Debit(W); // Withdrawl
                Console.WriteLine($"\tBalance after {W:C} withdrawl: {mySavings.Balance:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t*** WITHDRAWAL FAILED: {ex.Message} ***");
            }
            decimal i = mySavings.CalculateInterest(); // Interest on balance
            mySavings.Credit(i); // Pay interest on balance
            Console.WriteLine($"\tAccount balance after earning {mySavings.Rate}% interest, which is {i:C}: {mySavings.Balance:C}");

            // Exit
            Console.Write("\nPress any key to exit ");
            Console.ReadKey();

            //void ShowNext()
            //{
            //    Console.Write("\nPress any key to show next account: ");
            //    Console.ReadKey();
            //    Console.Clear();
            //}
        }
    }
}

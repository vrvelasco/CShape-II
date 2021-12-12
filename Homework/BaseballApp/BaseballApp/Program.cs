using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseballApp.BaseballEntities db = new BaseballApp.BaseballEntities();

            // Display the names and batting averages of all players in the Players table in order by the player’s
            // last name descending.
            PrintInfo("IN ORDER BY PLAYER'S LAST NAME"
                , db.Players.OrderByDescending(l => l.LastName));

            // Display the name and average of the players whose first names begin with ‘J’
            PrintInfo("\nPLAYER'S WITH FIRST NAMES THAT BEGIN WITH \"J\""
                , db.Players.Where(j => j.FirstName.StartsWith("J")));

            // Display the names and batting averages of all players with a batting average between 0.3 and 0.35.
            PrintInfo("\nPLAYERS WITH AVERAGES BETWEEN 0.3 AND 0.35", db.Players.Where(a => a.BattingAverage >= 0.3M && a.BattingAverage <= 0.35M));

            // Exit
            Console.Write("\nPress any key to exit ");
            Console.ReadKey();
        } 

        // Methods
        static void PrintInfo(string t, IEnumerable<Player> d)
        {
            Console.WriteLine(t); // Title
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{"Player's Name",-20}{"Batting Averages"}"); // Columns
            Console.BackgroundColor = ConsoleColor.Black;

            foreach (Player p in d)
            {
                Console.WriteLine($"{p.FullName,-20}{p.BattingAverage}");
            }
        }
    }

    public partial class Player
    {
        public string FullName { get => $"{FirstName} {LastName}"; }
    }
}

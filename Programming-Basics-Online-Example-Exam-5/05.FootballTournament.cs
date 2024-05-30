using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int totalGames = int.Parse(Console.ReadLine());
            double countWins = 0;
            double countDraws = 0;
            double countLost = 0;
            double points = 0;
            if (totalGames <= 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season."); return;
            }
            for (int i = 1; i <= totalGames; i++)
            {
                string playedMeetings = Console.ReadLine();
                switch (playedMeetings)
                {
                    case "W": countWins++; points += 3; break;
                    case "D": countDraws++; points += 1; break;
                    case "L": countLost++; break;
                }
            }
            Console.WriteLine($"{teamName} has won {points} points during this season.\nTotal stats:");
            Console.WriteLine($"## W: {countWins}");
            Console.WriteLine($"## D: {countDraws}");
            Console.WriteLine($"## L: {countLost}");
            Console.WriteLine($"Win rate: {countWins / totalGames * 100:F2}%");
        }
    }
}

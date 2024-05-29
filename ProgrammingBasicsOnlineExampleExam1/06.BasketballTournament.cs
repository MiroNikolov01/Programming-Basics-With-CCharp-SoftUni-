using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTournament = string.Empty;
            int countWin = 0;
            int countLost = 0;
            int totalGames = 0;
            while ((nameOfTournament = Console.ReadLine()) != "End of tournaments")
            {
            int countOfTournaments = int.Parse(Console.ReadLine());
                for (int i = 1; i <= countOfTournaments; i++)
                {
                    int desyTeam = int.Parse(Console.ReadLine());
                    int enemyTeam = int.Parse(Console.ReadLine());
                    if (desyTeam > enemyTeam)
                    {
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: win with {desyTeam - enemyTeam} points.");
                        countWin++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {nameOfTournament}: lost with {enemyTeam - desyTeam} points.");
                        countLost++;
                    }
                    totalGames++;
                    
                }

            }
            double averageWins = (double)countWin / totalGames * 100;
            double averageLoses = (double)countLost / totalGames * 100;
            Console.WriteLine($"{averageWins:F2}% matches win");
            Console.WriteLine($"{averageLoses:F2}% matches lost");

        }
    }
}

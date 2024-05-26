using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int wins = 0;
            int finalPoints = 0;
            int stagePointCounter = 0;
            for (int i = 0; i < countTournaments; i++)
            {
                finalPoints += startingPoints;
                startingPoints = 0;

                string stage = Console.ReadLine();
                switch (stage)
                {
                    case "W":
                        finalPoints += 2000; wins++; stagePointCounter += 2000; break;
                    case "F":
                        finalPoints += 1200; stagePointCounter += 1200; break;
                    case "SF":
                        finalPoints += 720; stagePointCounter += 720; break;
                }
            }
            double avaragePoints = (stagePointCounter / countTournaments);
            double percent = (double)wins / countTournaments * 100;
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {avaragePoints}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}

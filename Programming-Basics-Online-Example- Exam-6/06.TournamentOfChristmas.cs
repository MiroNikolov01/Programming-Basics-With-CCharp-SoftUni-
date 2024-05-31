using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfSport = string.Empty;
            double totalSum = 0;
            int totalWins = 0;
            int totalLosses = 0;
            int daysOfTournament = int.Parse(Console.ReadLine());
            for (int i = 1; i <= daysOfTournament; i++)
            {
                double sum = 0;
                int winsCounter = 0;
                int lossesCounter = 0;
                winsCounter = 0;
                lossesCounter = 0;
                while ((typeOfSport = Console.ReadLine()) != "Finish")
                {
                    string winOrLose = Console.ReadLine();
                    switch (winOrLose)
                    {
                        case "win": totalWins++; winsCounter++; sum += 20; break;
                        case "lose": totalLosses++; lossesCounter++; break;
                    }
                }
                if (winsCounter > lossesCounter)
                {
                    sum *= 1.1;
                }
                totalSum += sum;
            }
            if (totalWins > totalLosses)
            {
                totalSum *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalSum:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalSum:f2}");
            }
        }
    }
}

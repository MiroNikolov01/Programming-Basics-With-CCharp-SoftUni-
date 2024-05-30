using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = string.Empty;
            int maxPoints = int.MinValue;
            string winner = string.Empty;
            int points = 0;
            while ((playerName = Console.ReadLine()) != "Stop")
            {
                points = 0;
                for (int i = 0; i < playerName.Length; i++)
                {
                    int n = int.Parse(Console.ReadLine());
                    char symbol = playerName[i];
                    if (symbol == n)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                    if (points >= maxPoints)
                    {
                        maxPoints = points;
                        winner = playerName;
                    }
                }
            }
            Console.WriteLine($"The winner is {winner} with {maxPoints} points!");
        }
    }
}

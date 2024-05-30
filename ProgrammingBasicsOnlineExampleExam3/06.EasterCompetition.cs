using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEasterBread = int.Parse(Console.ReadLine());
            int maxRate = int.MinValue;
            string maxChef = string.Empty;
            string input = string.Empty;
            string chef = string.Empty;
            for (int i = 1; i <= countEasterBread; i++)
            {
               int points = 0;
                chef = Console.ReadLine();
                while ((input = Console.ReadLine()) != "Stop")
                {
                    int rate = int.Parse(input);
                    points += rate;
                }
                if (input == "Stop")
                {
                    Console.WriteLine($"{chef} has {points} points.");
                    if (points > maxRate)
                    {
                        maxChef = chef;
                        maxRate = points;
                        Console.WriteLine($"{chef} is the new number 1!");
                    }
                }
            }
            if (input == "Stop")
            {
            Console.WriteLine($"{maxChef} won competition with {maxRate} points!");
            }
        }
    }
}

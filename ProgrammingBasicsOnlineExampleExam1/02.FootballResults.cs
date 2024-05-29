using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int lost = 0;
            int draw = 0;
            string result1 = Console.ReadLine();
            string result2 = Console.ReadLine();
            string result3 = Console.ReadLine();

           
            char scoreOne1 = result1[0];
            char scoreTwo1 = result1[2];
            char scoreOne2 = result2[0];
            char scoreTwo2 = result2[2];
            char scoreOne3 = result3[0];
            char scoreTwo3 = result3[2];

            if (scoreOne1 > scoreTwo1)
            {
                win++;
            }
            else if (scoreOne1 < scoreTwo1)
            {
                lost++;
            }
            else
            {
                draw++;
            }

            if (scoreOne2 > scoreTwo2)
            {
                win++;
            }
            else if (scoreOne2 < scoreTwo2)
            {
                lost++;
            }
            else
            {
                draw++;
            }

            if (scoreOne3 > scoreTwo3)
            {
                win++;
            }
            else if (scoreOne3 < scoreTwo3)
            {
                lost++;
            }
            else
            {
                draw++;
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {draw}");
        }
    }
}


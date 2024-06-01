using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = 0;
            int countRed = 0;
            int countOrange = 0;
            int countYellow = 0;
            int countWhite = 0;
            int countBlack = 0;
            int otherColor = 0;
            for (int i = 0; i < n; i++)
            {
            string color = Console.ReadLine();
                switch (color)
                {
                    case "red": points += 5; countRed++; break;
                    case "orange": points += 10; countOrange++; break;
                    case "yellow": points += 15; countYellow++; break;
                    case "white": points += 20; countWhite++; break;
                    case "black": points /= 2; countBlack++; break;
                    default: otherColor++; break;
                }

            }
           
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {countRed}");
            Console.WriteLine($"Orange balls: {countOrange}");
            Console.WriteLine($"Yellow balls: {countYellow}");
            Console.WriteLine($"White balls: {countWhite}");
            Console.WriteLine($"Other colors picked: {otherColor}");
            Console.WriteLine($"Divides from black balls: {countBlack}");
        }
    }
}

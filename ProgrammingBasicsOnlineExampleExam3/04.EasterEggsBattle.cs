using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsFirstPlayer = int.Parse(Console.ReadLine());
            int eggsSecondPlayer = int.Parse(Console.ReadLine());
            string winner = string.Empty;

            while ((winner = Console.ReadLine()) != "End")
            {
                if (winner == "one")
                {
                    eggsSecondPlayer -= 1;
                }
                else if (winner == "two")
                {
                    eggsFirstPlayer -= 1;
                }
                if (eggsFirstPlayer == 0)
                {
                    break;
                }
                if (eggsSecondPlayer == 0)
                {
                    break;
                }
            }
            if (eggsFirstPlayer == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecondPlayer} eggs left.");
            }
            else if (eggsSecondPlayer == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirstPlayer} eggs left.");
            }
            if (winner == "End")
            {
                Console.WriteLine($"Player one has {eggsFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {eggsSecondPlayer} eggs left.");
            }
        }
    }
}

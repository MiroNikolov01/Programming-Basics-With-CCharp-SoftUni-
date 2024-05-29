using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();
            string command = string.Empty;

            int pointsFirstPlayer = 0;
            int pointsSecondPlayer = 0;

            while ((command = Console.ReadLine()) != "End of game")
            {
                int firstCard = int.Parse(command);
                int secondCard = int.Parse(Console.ReadLine());
                if (firstCard > secondCard)
                {
                    pointsFirstPlayer += firstCard - secondCard;
                }
                else if (secondCard > firstCard)
                {
                    pointsSecondPlayer += secondCard - firstCard;
                }
                if (firstCard == secondCard)
                {
                    firstCard = int.Parse(Console.ReadLine());
                    secondCard = int.Parse(Console.ReadLine());
                    if (firstCard > secondCard)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{firstPlayer} is winner with {pointsFirstPlayer} points");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{secondPlayer} is winner with {pointsSecondPlayer} points");
                        return;
                    }
                }
            }
            if (command == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {pointsFirstPlayer} points");
                Console.WriteLine($"{secondPlayer} has {pointsSecondPlayer} points");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSum = int.MinValue;
            string maxName = string.Empty;
            string command = string.Empty;
            int countMovies = 0;
            int points = 0;
            while ((command = Console.ReadLine()) != "STOP")
            {
                countMovies++;
                points = 0;
                for (int i = 0; i < command.Length; i++)
                {
                    char symbol = command[i];
                         points += symbol;
                    if (symbol >= 97 && symbol <= 122)
                    {
                        points -= command.Length * 2;
                    }
                    else if (symbol >= 65 && symbol <= 90)
                    {
                        points -= command.Length;
                    }
                }
                if (points > maxSum)
                {
                    maxSum = points;
                    maxName = command;
                }
                if (countMovies >= 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
            }
            Console.WriteLine($"The best movie for you is {maxName} with {maxSum} ASCII sum.");
        }
    }
}

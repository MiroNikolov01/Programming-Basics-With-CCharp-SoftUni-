using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cakePieces = length * width;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "STOP")
            {
               int pieces = int.Parse(input);
                cakePieces -= pieces; // Taking pieces from the cake
                if (cakePieces <= 0)
                {
                     break;
                }
            }
            if (cakePieces <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
            else if (input == "STOP")
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
        }
    }
}

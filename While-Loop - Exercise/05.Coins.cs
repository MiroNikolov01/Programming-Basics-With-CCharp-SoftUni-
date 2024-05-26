using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int coin = 0;
            while (input > 0)
            {
                input = Math.Round(input, 2);
                if (input >= 3)
                {
                    input -= 2;
                    coin++;
                }
                else if (input >= 2)
                {
                    input -= 2;
                    coin++;
                }
                else if (input >= 1)
                {
                    input -= 1;
                        coin++;
                }
                else if (input >= 0.50)
                {
                    input -= 0.50;
                        coin++;
                }
                else if (input >= 0.20)
                {
                    input -= 0.20;
                        coin++;
                }
                else if (input >= 0.10)
                {
                    input -= 0.10;
                        coin++;
                }
                else if (input >= 0.05)
                {
                    input -= 0.05;
                        coin++;
                }
                else if (input >= 0.02)
                {
                    input -= 0.02;
                        coin++;
                }
                else if (input >= 0.01)
                {
                    input -= 0.01;
                        coin++;
                }
            }
            Console.WriteLine(coin);
        }
    }
}

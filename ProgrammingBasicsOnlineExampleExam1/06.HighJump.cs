using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int barHightToAchieve = int.Parse(Console.ReadLine());
            int lowerBarHight = barHightToAchieve - 30;
            int countJumps = 0;
            int countFails = 0;
            bool success = false;
            bool failure = false;
            while (!success && !failure)
            {
                int attempt = int.Parse(Console.ReadLine());
                countJumps++;
                if (lowerBarHight < attempt)
                {
                    countFails = 0;
                    lowerBarHight += 5;
                }
                else 
                {
                    countFails++;
                }
                if (barHightToAchieve < lowerBarHight) success = true;
                if (countFails == 3) failure = true;
            }
            if (success)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {lowerBarHight-5}cm after {countJumps} jumps.");
            }
            else if (failure)
            {
                Console.WriteLine($"Tihomir failed at {lowerBarHight}cm after {countJumps} jumps.");
            }
        }
    }
}


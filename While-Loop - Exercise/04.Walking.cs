using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int totalSteps = 0;
            while ((input = Console.ReadLine()) != "Going home")
            {
                int steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!\n{Math.Abs(totalSteps - 10000)} steps over the goal!"); return;
                }
            }
            if (input == "Going home")
            {
            totalSteps += int.Parse(Console.ReadLine());
                if (totalSteps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!\n{Math.Abs(totalSteps - 10000)} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(10000 - totalSteps)} more steps to reach goal.");
                }
            }
        }
    }
}


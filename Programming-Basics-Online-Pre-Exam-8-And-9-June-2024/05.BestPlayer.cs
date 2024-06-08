using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {

            string namePlayer = string.Empty;
            int maxGoals = int.MinValue;
            string maxPlayer = string.Empty;
            int goals = 0;
            while ((namePlayer = Console.ReadLine()) != "END")
            {
                goals = int.Parse(Console.ReadLine());
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    maxPlayer = namePlayer;
                }
                if (goals >= 10)
                {
                    break;
                }
            }
            if(goals >= 3)
            {
                Console.WriteLine($"{maxPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{maxPlayer} is the best player!");
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}

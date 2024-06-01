using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = string.Empty;
            string maxName = string.Empty;
            bool hatTrick = false;
            int maxGoals = int.MinValue;
            while ((playerName = Console.ReadLine()) != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals > maxGoals)
                {
                    maxName = playerName;
                    maxGoals = goals;
                }
                if (goals >= 3) hatTrick = true;
                if (goals >= 10)
                {
                    Console.WriteLine($"{maxName} is the best player!\nHe has scored {maxGoals} goals and made a hat-trick !!!"); Environment.Exit(0);
                }
            }
            if (hatTrick == true)
            {
                Console.WriteLine($"{maxName} is the best player!\nHe has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{maxName} is the best player!\nHe has scored {maxGoals} goals.");
            }
        }
    }
}

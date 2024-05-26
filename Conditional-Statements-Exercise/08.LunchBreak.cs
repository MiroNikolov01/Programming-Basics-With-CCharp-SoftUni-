using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfFilm = Console.ReadLine();
            int timeForFilm = int.Parse(Console.ReadLine());
            int timeForBreak = int.Parse(Console.ReadLine());

            double timeLunch = timeForBreak * 0.125;
            double timeBreak = timeForBreak * 0.25;
            double timeLeft =(timeForBreak - timeLunch - timeBreak);
            double diffrence = Math.Abs(timeForFilm - timeLeft);
            if (timeLeft >= timeForFilm)
            {
                Console.WriteLine($"You have enough time to watch {nameOfFilm} and left with {Math.Ceiling(diffrence)} minutes free time.");
            }
            else
            {
                double timeNeeded = Math.Ceiling(timeForBreak - timeLunch - timeBreak);
                Console.WriteLine($"You don't have enough time to watch {nameOfFilm}, you need {Math.Ceiling(diffrence)} more minutes.");
            }
        }
    }
}

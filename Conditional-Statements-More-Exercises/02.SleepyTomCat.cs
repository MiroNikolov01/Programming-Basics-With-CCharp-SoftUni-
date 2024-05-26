using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int minutesForPlayOff = daysOff * 127;
            int minutesForPlayWorking = (365 - daysOff) * 63;
            int normPlay = 30000;
            int realTimeForPlay = minutesForPlayOff + minutesForPlayWorking;
            int diffrenceInNorm = normPlay - realTimeForPlay;
            int hours = Math.Abs(diffrenceInNorm / 60);
            int minutes = Math.Abs(diffrenceInNorm % 60);

            if (normPlay > realTimeForPlay)
            {
                Console.WriteLine($"Tom sleeps well\n{hours} hours and {minutes} minutes less for play");
            }
            if (normPlay < realTimeForPlay)
            {
                Console.WriteLine($"Tom will run away\n{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}

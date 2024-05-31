using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeInSecForM = double.Parse(Console.ReadLine());
            //calculations
            var neededSec = distanceInM * timeInSecForM;
            var delayTime = Math.Floor((distanceInM / 50)) * 30;
            var totalTime = neededSec + delayTime;
            var diffrence = Math.Abs(totalTime - recordInSec);
            if (recordInSec > totalTime) Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            else Console.WriteLine($"No! He was {diffrence:F2} seconds slower.");
           
        }
    }
}

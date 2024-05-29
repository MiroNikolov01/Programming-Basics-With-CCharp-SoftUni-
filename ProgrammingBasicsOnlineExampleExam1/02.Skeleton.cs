using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlMinutes = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            int secondsFor100M = int.Parse(Console.ReadLine());

            int controlTimeInSec = controlMinutes * 60 + controlSeconds;
            double slowingTime = distanceInM / 120;
            double totalSlowTime = slowingTime * 2.5;
            double marinTime = (distanceInM / 100) * secondsFor100M - totalSlowTime;
            if (marinTime <= controlTimeInSec)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!\nHis time is {marinTime:f3}.");
            }
            else if (marinTime > controlTimeInSec)
            {
                double neededSeconds = marinTime - controlTimeInSec;
                Console.WriteLine($"No, Marin failed! He was {neededSeconds:f3} second slower.");
            }
        }
    }
}

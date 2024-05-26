using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double recordByIvan = distance * timePerMeter;

            double deleyTime = Math.Floor(distance / 15) * 12.5;

            recordByIvan += deleyTime;

            double different = worldRecord - recordByIvan;

            if (different > 0)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(different):f2} seconds slower.");
            }
        }
    }
}
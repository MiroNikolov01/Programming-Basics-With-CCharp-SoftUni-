using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumePool = int.Parse(Console.ReadLine());
            int pipeOneH = int.Parse(Console.ReadLine());
            int pipeTwoH = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double totalLitresPipeOne = pipeOneH * hours;
            double totalLitresPipeTwo = pipeTwoH * hours;
            double totalLitresPipes = totalLitresPipeOne + totalLitresPipeTwo;
            double poolPercentFull = (totalLitresPipes / volumePool) * 100;

            if (totalLitresPipes <= volumePool)
            {
                double percentPipeOne = (totalLitresPipeOne / totalLitresPipes) * 100;
                double percentPipeTwo = (totalLitresPipeTwo / totalLitresPipes) * 100;
                Console.WriteLine($"The pool is {poolPercentFull:F2}% full. Pipe 1: {percentPipeOne:F2}%. Pipe 2: {percentPipeTwo:F2}%.");
            }
            else
            {
                double overflowLitres = totalLitresPipes - volumePool;
                Console.WriteLine($"For {hours} hours the pool overflows with {overflowLitres:F2} liters.");

            }
        }
    }
}
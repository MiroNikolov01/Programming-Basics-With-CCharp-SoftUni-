using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            int cols = ((int)width - 100) / 70;
            int rows = (int)length / 120;
            int seats = rows * cols - 3;
            Console.WriteLine(seats);

        }
    }           
}   
    


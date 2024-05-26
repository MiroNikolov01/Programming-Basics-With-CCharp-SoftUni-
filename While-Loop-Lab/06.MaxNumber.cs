using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int maxNum = int.MinValue;
            while ((command = Console.ReadLine()) != "Stop")
            {
                int sum = int.Parse(command);
                if (sum > maxNum)
                {
                    maxNum = sum;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}

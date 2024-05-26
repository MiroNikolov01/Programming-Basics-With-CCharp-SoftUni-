using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int minNum = int.MaxValue;
            while ((command = Console.ReadLine()) != "Stop")
            {
                int sum = int.Parse(command);
                if (sum < minNum)
                {
                    minNum = sum;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}

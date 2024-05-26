using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int timeleftForDeposit = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            procent = procent / 100;

            double price = deposit + timeleftForDeposit * ((deposit * procent) / 12);
            Console.WriteLine(price);

        }
    }
}

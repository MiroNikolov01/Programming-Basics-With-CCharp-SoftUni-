using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededSum = double.Parse(Console.ReadLine());
            string command = "";
            double sumCash = 0;
            double sumCard = 0;
            int countCash = 0;
            double countCard = 0;
            double totalSum = 0;
            int change = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                double price = double.Parse(command);
              
                change++;
                if (change % 2 == 1) //Cash
                {
                    if (price > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        totalSum += price;
                        countCash++;
                        sumCash += price;
                        Console.WriteLine("Product sold!");
                    }
                }
                else  //Card 
                {
                    if (price < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        totalSum += price;
                        countCard++;
                        sumCard += price;
                        Console.WriteLine("Product sold!");
                    }
                }
                if (neededSum <= totalSum)
                {
                    break;
                }
            }
            double averageCardSum = (double)sumCard / countCard;
            double averageCashSum = (double)sumCash / countCash;
            if (neededSum <= totalSum)
            {
                Console.WriteLine($"Average CS: {averageCashSum:F2}");
                Console.WriteLine($"Average CC: {averageCardSum:F2}");
            }
            else if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededSumVacation = double.Parse(Console.ReadLine());
            double JesyMoney = double.Parse(Console.ReadLine());
            int countSpendRow = 0;
            int totalDays = 0;
            while (true)
            {
                string decision = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                totalDays++;
                if (decision == "spend")
                {
                    JesyMoney -= sum;
                    if (JesyMoney < sum)
                    {
                        JesyMoney = 0;
                    }
                    countSpendRow++;
                    if (countSpendRow == 5)
                    {
                        Console.WriteLine($"You can't save the money.\n{totalDays}"); return;
                       
                    }
                }
                else if (decision == "save")
                {
                    countSpendRow = 0;
                    JesyMoney += sum;
                }
                if (neededSumVacation <= JesyMoney)
                {
                    Console.WriteLine($"You saved the money for {totalDays} days.");
                    return;
                }
            }
        }
    }
}

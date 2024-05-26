using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceOneToy = int.Parse(Console.ReadLine());

            int lillySavedMoney = 0;
            int moneyEvenBirthday = 10;
            int countToys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    lillySavedMoney += moneyEvenBirthday - 1;
                    moneyEvenBirthday += 10;
                }
                else countToys++;
            }
            lillySavedMoney += countToys * priceOneToy;
            double money = Math.Abs(priceWashingMachine - lillySavedMoney);
            if (lillySavedMoney >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {money:F2}");
            }
            else
            {
                Console.WriteLine($"No! {money:f2}");
            }
        }
    }
}

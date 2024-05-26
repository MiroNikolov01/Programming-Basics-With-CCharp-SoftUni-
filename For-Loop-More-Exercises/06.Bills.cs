using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int avarageMonthExpense = int.Parse(Console.ReadLine());
            double electricity = 0.0;
            double water = 0.0;
            double internet = 0.0;
            double other = 0.0;
            for (int i = 0; i < avarageMonthExpense; i++)
            {
                double monthExpenses = double.Parse(Console.ReadLine());
                electricity += monthExpenses;
                other += (monthExpenses + 20 + 15) * 1.20;
            }
                water += avarageMonthExpense * 20;
                internet += avarageMonthExpense * 15;
            double avarageExpense = (electricity + water + internet + other) / avarageMonthExpense;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:F2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {other:F2} lv");
            Console.WriteLine($"Average: {avarageExpense:f2} lv");
        }
    }
}

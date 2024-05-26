using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGroups = int.Parse(Console.ReadLine());
            int countMusala = 0;
            int countMonblan = 0;
            int countKilimanjaro = 0;
            int countK2 = 0;
            int countEverest = 0;
            double totalSum = 0;
            for (int i = 0; i < countGroups; i++)
            {
                int countPeople = int.Parse(Console.ReadLine());
                totalSum += countPeople;
                if (countPeople <= 5) countMusala += countPeople;
                else if (countPeople >= 6 && countPeople <= 12) countMonblan += countPeople;
                else if (countPeople >= 13 && countPeople <= 25) countKilimanjaro += countPeople;
                else if (countPeople >= 26 && countPeople <= 40) countK2 += countPeople;
                else if (countPeople >= 41) countEverest += countPeople;
            }
            double percentMusala = (double)(countMusala / totalSum) * 100;
            double percentMonblan = (double)countMonblan / totalSum * 100;
            double percentKilimanjaro = (double)countKilimanjaro / totalSum * 100;
            double percentK2 = (double)countK2 / totalSum * 100;
            double percentEverest = (double)countEverest / totalSum * 100;
            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMonblan:f2}%");
            Console.WriteLine($"{percentKilimanjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGroups = int.Parse(Console.ReadLine());
            double countMusala = 0;
            double countMonblan = 0;
            double countKilimanjaro = 0;
            double countK2 = 0;
            double countEverest = 0;
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
            
            Console.WriteLine($"{countMusala / totalSum * 100:f2}%");
            Console.WriteLine($"{countMonblan / totalSum * 100:f2}%");
            Console.WriteLine($"{countKilimanjaro / totalSum * 100:f2}%");
            Console.WriteLine($"{countK2 / totalSum * 100:f2}%");
            Console.WriteLine($"{countEverest / totalSum * 100:f2}%");
        }
    }
}

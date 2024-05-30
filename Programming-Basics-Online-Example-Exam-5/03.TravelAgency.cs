using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string packet = Console.ReadLine();
            string yOrNo = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            bool isTrue1 = city == "Bansko" || city == "Borovets";
            bool isTrue2 = city == "Varna" || city == "Burgas";
            if (countDays > 7)
            {
                countDays -= 1;
            }
            if (isTrue1)
            {
                switch (packet)
                {
                    case "withEquipment": totalPrice = countDays * 100;
                        if (yOrNo == "yes")
                        {
                            totalPrice *= 0.90;
                        }
                        break;
                    case "noEquipment": totalPrice = countDays * 80;
                        if (yOrNo == "yes")
                        {
                            totalPrice *= 0.95;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        return;
                }
            }
            if (isTrue2)
            {
                switch (packet)
                {
                    case "withBreakfast": totalPrice = countDays * 130;
                        if (yOrNo == "yes")
                        {
                            totalPrice *= 0.88;
                        }
                        break;
                    case "noBreakfast": totalPrice = countDays * 100;
                        if (yOrNo == "yes")
                        {
                            totalPrice *= 0.93;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        return;
                }
            }
            if (countDays < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            if (isTrue1 == true || isTrue2 == true)
            {
                Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
            }
            if (isTrue1 == false && isTrue2 == false)
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string termContract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string addedMobileInternet = Console.ReadLine();
            int totalMonthPayment = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            switch (typeOfContract)
            {
                case "Small":
                    switch (termContract)
                    {
                        case "one": totalPrice = 9.98; break;
                        case "two": totalPrice = 8.58; break;
                    }
                    break;
                case "Middle":
                    switch (termContract)
                    {
                        case "one": totalPrice = 18.99; break;
                        case "two": totalPrice = 17.09; break;
                    }
                    break;
                case "Large":
                    switch (termContract)
                    {
                        case "one": totalPrice = 25.98; break;
                        case "two": totalPrice = 23.59; break;
                    }
                    break;
                case "ExtraLarge":
                    switch (termContract)
                    {
                        case "one": totalPrice = 35.99; break;
                        case "two": totalPrice = 31.79; break;
                    }
                    break;
            }
            if (totalPrice <= 10 && addedMobileInternet == "yes")
            {
                totalPrice += 5.50;
            }
            else if (totalPrice <= 30 && addedMobileInternet == "yes")
            {
                totalPrice += 4.35;
            }
            else if (totalPrice > 30)
            {
                totalPrice += 3.85;
            }
            if (termContract == "two")
            {
                totalPrice = totalPrice - (totalPrice * 0.0375);
            }
            Console.WriteLine($"{totalPrice * totalMonthPayment:F2} lv.");
        }
    }
}



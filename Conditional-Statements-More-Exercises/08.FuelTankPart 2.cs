using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FuelTankPart_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();
            //fuel prices
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            double regularPrice = 0.0;
            if (fuel == "Gasoline" || fuel == "Diesel" || fuel == "Gas")
            {

                if (card == "Yes" && fuel == "Gasoline")
                {
                    regularPrice = volume * (gasoline - 0.18);
                }
                else if (card == "Yes" && fuel == "Diesel")
                {
                    regularPrice = volume * (diesel - 0.12);
                }
                else if (card == "Yes" && fuel == "Gas")
                {
                    regularPrice = volume * (gas - 0.08);
                }
                else if (card == "No" && fuel == "Gasoline")
                {
                    regularPrice = volume * gasoline;
                }
                else if (card == "No" && fuel == "Diesel")
                {
                    regularPrice = volume * diesel;
                }
                else if (card == "No" && fuel == "Gas")
                {
                    regularPrice = volume * gas;
                }

            }
            
            if (volume >= 20 && volume <= 25)
            {
                regularPrice *= 0.92;
            }
            if (volume > 25)
            {
                regularPrice *= 0.90;
            }
            Console.WriteLine($"{regularPrice:f2} lv.");

            }


        }

    }





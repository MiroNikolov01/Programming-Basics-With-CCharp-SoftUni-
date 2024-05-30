using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int rent = int.Parse(Console.ReadLine());
            //calculations 
            double priceForstatuette = rent - (rent * 0.30); //30% from rent
            double priceForCatering = priceForstatuette - (priceForstatuette * 0.15); //15% from statuette
            double priceForSound = priceForCatering * 0.5; //1/2 from catering
            double totalPrice = rent + priceForstatuette + priceForCatering + priceForSound;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}

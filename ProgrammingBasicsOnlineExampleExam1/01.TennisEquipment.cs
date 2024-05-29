using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double OneRacket = double.Parse(Console.ReadLine());
            int countRackets = int.Parse(Console.ReadLine());
            double pairsShoes = int.Parse(Console.ReadLine());

           

            double priceRacket = countRackets * OneRacket;
            double priceShoes = OneRacket / 6;
            double priceAllShoes = pairsShoes * priceShoes;

            double leftEquipment = (priceRacket + priceAllShoes) * 0.2;
            double totalPrice = priceRacket + priceAllShoes + leftEquipment;

            double priceForDjokovic = Math.Floor(totalPrice /8);
            double priceForSponsors = Math.Ceiling(totalPrice * 0.875);

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceForDjokovic)}\nPrice to be paid by sponsors {Math.Round(priceForSponsors)}");
           
        }
    }
}

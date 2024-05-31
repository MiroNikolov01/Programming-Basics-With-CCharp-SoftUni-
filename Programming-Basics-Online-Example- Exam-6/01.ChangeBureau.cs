using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            var countBitcoin = int.Parse(Console.ReadLine());
            var countChineaseYan = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
            //value prices per one
            var bitcoin = 1168; //leva
            var chianeseYan = 0.15; //dollar
            var dollar = 1.76; //leva
            var euro = 1.95; //leva

            //calculations
            
            var priceBitcoint = bitcoin * countBitcoin; // price bitcoin in lev
            
            var yanToDollar = chianeseYan * countChineaseYan; //from yan to dollar
            var dollarToLev = yanToDollar * dollar; //from dollar to lev convert value
            var totalLev = priceBitcoint + dollarToLev;
            var totalLevToEuro = totalLev / euro  ;
            var comissionTotal = (totalLevToEuro * comission) / 100;
            var total = totalLevToEuro - comissionTotal;
            Console.WriteLine($"{total:F2}");


        }
    }
}

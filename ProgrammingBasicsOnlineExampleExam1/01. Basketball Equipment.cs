using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02.Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            int yearFee = int.Parse(Console.ReadLine());
            //calculations 
            double basketballShoes = yearFee * (1 - 0.40);
            double basketballClothes = basketballShoes * (1 - 0.20);
            double basketballBall = basketballClothes * 0.25;
            double basketballAccessories = basketballBall * 0.2;
            double totalBasketballEquipment = yearFee + basketballShoes + basketballClothes + basketballBall + basketballAccessories;
            //output
            Console.WriteLine(totalBasketballEquipment);
        }
    }
}

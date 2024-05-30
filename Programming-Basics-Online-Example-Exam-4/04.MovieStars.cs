using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetActor = double.Parse(Console.ReadLine());

            string nameActor = string.Empty;
            double payCheck = 0.0;
            double percent = 0.0;
            while ((nameActor = Console.ReadLine()) != "ACTION")
            {
                if (nameActor.Length <= 15)
                {
                payCheck = double.Parse(Console.ReadLine());
                    if (budgetActor < payCheck)
                    {
                        Console.WriteLine($"We need {payCheck - budgetActor:f2} leva for our actors.");
                        return;
                    }
                    budgetActor -= payCheck;
                }
                else
                {
                     percent = Math.Abs(budgetActor * 0.80 - budgetActor);
                    budgetActor -= percent;
                }
            }
            if (nameActor == "ACTION")
            {
                Console.WriteLine($"We are left with {budgetActor:f2} leva.");
            }

        }
    }
}



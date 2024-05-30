using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int countJudges = int.Parse(Console.ReadLine());
            double points = 0.0;

            for (int i = 0; i < countJudges; i++)
            {
                string nameJudge = Console.ReadLine();
                double pointsFromJudge = double.Parse(Console.ReadLine());
                pointsAcademy += ((nameJudge.Length * pointsFromJudge) / 2);
                points += pointsAcademy;

                pointsAcademy = 0;


                if (points > 1250.5)
                {
                    break;
                }

            }
            if (points >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:F1}!");
            }
            else
            {
                double neededPoints = 1250.5 - points;
                Console.WriteLine($"Sorry, {actor} you need {neededPoints:f1} more!");
            }
        }

    }
}

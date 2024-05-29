using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoints = 301;
            int countShots = 0;
            int missedShots = 0;
            int points = 0;
            string namePlayer = Console.ReadLine();

            string field = string.Empty;
            while ((field = Console.ReadLine()) != "Retire")
            {
                points = int.Parse(Console.ReadLine());

                switch (field)
                {
                    case "Single":

                        if (startPoints >= points)
                        {
                            startPoints -= points;
                            countShots++;
                        }
                        else
                        {
                            missedShots++;
                        }
                        break;
                    case "Double":
                        points *= 2;
                        if (startPoints >= points)
                        {
                            startPoints -= points;
                            countShots++;
                        }
                        else
                        {
                            missedShots++;
                        }
                        break;
                    case "Triple":
                        points *= 3;

                        if (startPoints >= points)
                        {
                            startPoints -= points;
                            countShots++;
                        }
                        else
                        {
                            missedShots++;
                        }
                        break;
                }
                if (startPoints == 0)
                {
                    break;
                }
            }
            if (startPoints == 0)
            {
                Console.WriteLine($"{namePlayer} won the leg with {countShots} shots.");

            }
            if (field == "Retire")
            {
                Console.WriteLine($"{namePlayer} retired after {missedShots} unsuccessful shots.");

            }
        }
    }
}

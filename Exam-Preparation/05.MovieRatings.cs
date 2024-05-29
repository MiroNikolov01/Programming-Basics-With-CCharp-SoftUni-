using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int filmDessy = int.Parse(Console.ReadLine());
            double maxRate = int.MinValue;
            double minRate = int.MaxValue;
            string maxMovie = string.Empty;
            string minMovie = string.Empty;
           double allRates = 0;
            for (int i = 1; i <= filmDessy; i++)
            {
                string nameFilm = Console.ReadLine();
                double rate = double.Parse(Console.ReadLine());
                allRates += rate;
                if (rate > maxRate)
                {
                    maxMovie = nameFilm;
                    maxRate = rate;
                }
                if (rate < minRate)
                {
                    minMovie = nameFilm;
                    minRate = rate;
                }

            }
            double averageRate = (allRates / filmDessy);
            Console.WriteLine($"{maxMovie} is with highest rating: {maxRate:F1}");
            Console.WriteLine($"{minMovie} is with lowest rating: {minRate:F1}");
            Console.WriteLine($"Average rating: {averageRate:f1}");
        }
    }
}

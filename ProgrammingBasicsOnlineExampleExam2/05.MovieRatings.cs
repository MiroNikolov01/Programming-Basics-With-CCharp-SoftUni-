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
            int countMovies = int.Parse(Console.ReadLine());
            double maxRating = 0.0;
            double minRating = double.MaxValue;
            double totalRating = 0.0;
            string nameMovieMax = string.Empty;
            string nameMovieMin = string.Empty;
            for (int i = 1; i <= countMovies; i++)
            {
                 string nameMovie = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());
                totalRating += movieRating;
                if (movieRating > maxRating)
                {
                    maxRating = movieRating;
                    nameMovieMax = nameMovie;
                }
                if (movieRating < minRating)
                {
                    minRating = movieRating;
                    nameMovieMin = nameMovie;
                }
            }
            double avarageRating = totalRating / countMovies;
            Console.WriteLine($"{nameMovieMax} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{nameMovieMin} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {avarageRating:f1}");
        }
    }
}

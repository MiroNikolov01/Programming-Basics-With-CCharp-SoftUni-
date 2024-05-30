using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            string nameSeries = Console.ReadLine();
            int countSeasons = int.Parse(Console.ReadLine());
            int countEpisodes = int.Parse(Console.ReadLine());
            double noAdsEpisode = double.Parse(Console.ReadLine());

            //Checking how much time do we need to watch all episodes of one series in minutes!
           
            double adsOneEpisode = noAdsEpisode * 0.20; // ads durability for one episode
            double oneEpisode = noAdsEpisode + adsOneEpisode; //durability for episode with ads
            double addedTimeEpisodes = countSeasons * 10; //added time from special episodes
            double totalTime =Math.Round(oneEpisode * countEpisodes * countSeasons + addedTimeEpisodes); //total time to watch

            Console.WriteLine($"Total time needed to watch the {nameSeries} series is {totalTime} minutes.");

        }
    }
}

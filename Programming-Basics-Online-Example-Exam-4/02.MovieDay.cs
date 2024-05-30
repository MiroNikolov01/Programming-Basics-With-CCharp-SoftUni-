using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForPictures = int.Parse(Console.ReadLine());
            int countScenes = int.Parse(Console.ReadLine());
            int durationScenes = int.Parse(Console.ReadLine());
            //calculatin if the photo day will be enough for filming
            double preperation = timeForPictures * 0.15;
            double timeForScenes = countScenes * durationScenes;
            double timeNeeded = preperation + timeForScenes;
            double minutesLeft = Math.Abs(timeNeeded - timeForPictures); // calculating the minutes left

            if (timeForPictures >= timeNeeded)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {(int)Math.Round(minutesLeft)} minutes left!");

            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {(int)Math.Round(minutesLeft)} minutes.");
            }
            

        }
    }
}

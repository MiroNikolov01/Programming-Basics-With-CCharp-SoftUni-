using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minuteArrival = int.Parse(Console.ReadLine());
            int timeToExam = hourExam * 60 + minutExam;
            int arrivalTime = hourArrival * 60 + minuteArrival;
            if (timeToExam < arrivalTime)
            {
                Console.WriteLine("Late");
                int timeLate = arrivalTime - timeToExam;
                if (timeLate<60)
                {
                    Console.WriteLine($"{timeLate} minutes after the start");
                }
                else
                {
                    int hours = timeLate / 60;
                    int minutes = timeLate % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
            }
            else if (timeToExam - 30 <= arrivalTime)
            {
                double timeLeft = Math.Abs(arrivalTime - timeToExam);
                Console.WriteLine("On time");
                if (timeToExam > arrivalTime)
                {
                    Console.WriteLine($"{timeLeft} minutes before the start");
                }


            }
            else if (timeToExam > arrivalTime)
            {
                int timeEarly = timeToExam - arrivalTime;
                Console.WriteLine("Early");
                if (timeEarly < 60)
                {
                    Console.WriteLine($"{timeEarly} minutes before the start");
                }
                else
                {
                    int hours = timeEarly / 60;
                    int minutes = timeEarly % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");


                }


            }
        }
    }
}
            
               
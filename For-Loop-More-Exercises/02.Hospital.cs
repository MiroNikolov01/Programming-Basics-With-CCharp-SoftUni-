using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeCalculation = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatiens = 0;
            int untreatedPatiens = 0;

            for (int i = 1; i <= timeCalculation; i++)
            {
                if (i % 3 == 0)
                {
                    if (untreatedPatiens > treatedPatiens)
                    {
                        doctors++;
                    }
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients <= doctors)
                {
                    treatedPatiens += patients;
                }
                else
                {
                   
                    untreatedPatiens += patients - doctors;
                    treatedPatiens += patients - (patients - doctors);
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatiens}.");
            Console.WriteLine($"Untreated patients: {untreatedPatiens}.");
        }
    }
}


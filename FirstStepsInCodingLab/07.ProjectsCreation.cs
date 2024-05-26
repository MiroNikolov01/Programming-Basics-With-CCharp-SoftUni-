using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hoursResult = projects * 3;
                Console.WriteLine($"The architect {name} will need {hoursResult} hours to complete {projects} project/s.");

        }
    }
}

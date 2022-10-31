using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int TimeReadinHours = numberPages / pagesPerHour;
            int daysNeeded = TimeReadinHours / days;

            Console.WriteLine(daysNeeded);
        }

    }
}

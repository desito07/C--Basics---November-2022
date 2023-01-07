using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statues = rent - rent * 0.30;
            double catering = statues - statues * 0.15;
            double sounding = catering * 0.5;
            double cost = (rent + statues + catering + sounding);

            Console.WriteLine($"{cost:f2}");

        }
    }
}




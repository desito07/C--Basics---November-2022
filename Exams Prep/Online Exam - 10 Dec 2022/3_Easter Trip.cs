using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double cost = 0.0;

            if(country == "France")
            {
               if(dates == "21-23")
                {
                    cost += nights * 30;
                }
               else if(dates == "24-27")
                {
                    cost += nights * 35;
                }
               else if(dates == "28-31")
                {
                    cost += nights * 40;
                }
            }
            else if(country == "Italy")
            {
                if (dates == "21-23")
                {
                    cost += nights * 28;
                }
                else if (dates == "24-27")
                {
                    cost += nights * 32;
                }
                else if (dates == "28-31")
                {
                    cost += nights * 39;
                }
            }
            else if(country == "Germany")
            {
                if (dates == "21-23")
                {
                    cost += nights * 32;
                }
                else if (dates == "24-27")
                {
                    cost += nights * 37;
                }
                else if (dates == "28-31")
                {
                    cost += nights * 43;
                }
            }
            Console.WriteLine($"Easter trip to {country} : {cost:f2} leva.");
        }
    }
}


using System;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string place = "";
            double cost = 0.00;


            if(budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    cost = budget * 0.3;
                }
                else if(season == "winter")
                {
                    place = "Hotel";
                    cost = budget * 0.70;
                }
            }
            else if(budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    cost = budget * 0.4;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    cost = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                cost = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.Write($"{place} - {cost:f2}");
        }
    }
}


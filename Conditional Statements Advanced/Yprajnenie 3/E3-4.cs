using System;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            double cost = 0.0;

            if (season == "Spring")
            {
                cost = 3000;
                if (num > 0 && num <= 6)
                {
                    cost -= cost * 0.1;
                }
                else if (num >= 7 && num <= 11)
                {
                    cost -= cost * 0.15;
                }
                else if (num >= 12)
                {
                    cost -= cost * 0.25;
                }
            }
            else if (season == "Summer")
            {
                cost = 4200;
                if (num > 0 && num <= 6)
                {
                    cost -= cost * 0.1;
                }
                else if (num >= 7 && num <= 11)
                {
                    cost -= cost * 0.15;
                }
                else if (num >= 12)
                {
                    cost -= cost * 0.25;
                }
            }
            else if (season == "Autumn")
            {
                cost = 4200;
                if (num > 0 && num <= 6)
                {
                    cost -= cost * 0.1;
                }
                else if (num >= 7 && num <= 11)
                {
                    cost -= cost * 0.15;
                }
                else if (num >= 12)
                {
                    cost -= cost * 0.25;
                }
            }
            else if (season == "Winter")
            {
                cost = 2600;
                if (num > 0 && num <= 6)
                {
                    cost -= cost * 0.1;
                }
                else if (num >= 7 && num <= 11)
                {
                    cost -= cost * 0.15;
                }
                else if (num >= 12)
                {
                    cost -= cost * 0.25;
                }
            }

            if(num % 2 == 0 && season != "Autumn")
            {
                cost -= cost * 0.05;
            }

            if (budget >= cost)
            {
                Console.WriteLine($"Yes! You have {(budget - cost):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(cost - budget):f2} leva.");
            }

        }
    }
}


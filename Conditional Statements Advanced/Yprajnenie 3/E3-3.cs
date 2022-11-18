using System;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double cost = 0.0;

            if (flower == "Roses")
            {
                cost = num * 5;
                if (num > 80)
                {
                    cost -= cost * 0.1;
                }
            }
            else if (flower == "Dahlias")
            {
                cost = num * 3.80;
                if (num > 90)
                {
                    cost -= cost * 0.15;
                }
            }
            else if (flower == "Tulips")
            {
                cost = num * 2.80;
                if (num > 80)
                {
                    cost -= cost * 0.15;
                }
            }
            else if (flower == "Narcissus")
            {
                cost = num * 3;
                if( num < 120)
                {
                    cost += cost * 0.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                cost = num * 2.5;
                if (num < 80)
                {
                    cost += cost * 0.2;
                }
            }

            if( budget >= cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {num} {flower} and {(budget - cost):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(cost - budget):f2} leva more.");
            }
        }
    }
}


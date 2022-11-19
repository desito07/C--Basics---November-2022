using System;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string accommodation = Console.ReadLine();
            string rating = Console.ReadLine();

            double cost = 0.00;

            if (accommodation == "room for one person")
            {
                cost = (days - 1) * 18;

            }
            else if (accommodation == "apartment")
            {
                cost = (days - 1) * 25;
                if (days < 10)
                {
                    cost -= cost * 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    cost -= cost * 0.35;
                }
                else if (days > 15)
                {
                    cost -= cost * 0.5;
                }
            }
            else if (accommodation == "president apartment")
            {
                cost = (days - 1) * 35;
                if (days < 10)
                {
                    cost -= cost * 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    cost -= cost * 0.15;
                }
                else if (days > 15)
                {
                    cost -= cost * 0.20;
                }
            }
            if (rating == "positive")
            {
                cost += cost * 0.25;
            }
            else if(rating == "negative")
            {
                cost -= cost * 0.1;
            }
            Console.WriteLine($"{cost:f2}");
        }
    }
}


using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sizeSet = Console.ReadLine();
            int orderedSets = int.Parse(Console.ReadLine());

            double price = 0;

            if(fruit == "Watermelon")
            {
                if(sizeSet == "small")
                {
                    price = orderedSets * 2 * 56;
                }
                else if(sizeSet == "big")
                {
                    price = orderedSets * 5 * 28.70;
                }
            }
            else if(fruit == "Mango")
            {
                if (sizeSet == "small")
                {
                    price = orderedSets * 2 * 36.66;
                }
                else if (sizeSet == "big")
                {
                    price = orderedSets * 5 * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (sizeSet == "small")
                {
                    price = orderedSets * 2 * 42.10;
                }
                else if (sizeSet == "big")
                {
                    price += orderedSets * 5 * 24.80;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (sizeSet == "small")
                {
                    price = orderedSets * 2 * 20;
                }
                else if (sizeSet == "big")
                {
                    price = orderedSets * 5 * 15.20;
                }
            }

            if(price >= 400 && price <= 1000)
            {
                price -= price * 0.15;
            }
            else if(price > 1000)
            {
                price -= price * 0.50;
            }
            Console.WriteLine($"{price:f2} lv.");

        }
    }
}


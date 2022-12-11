using System;

namespace Exam_111222
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string accommodation = Console.ReadLine();
            string feedback = Console.ReadLine();

            double cost = 0.0;

            if (accommodation == "room for one person")
            {
                cost = (days - 1) * 18;
            }
            else if (accommodation == "apartment")
            {
                cost = (days - 1) * 25;
                if (days <= 10)
                {
                    cost -= cost * 0.3;
                }
                else if (days > 10 && days <= 15)
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
                if (days <= 10)
                {
                    cost -= cost * 0.1;
                }
                else if (days > 10 && days <= 15)
                {
                    cost -= cost * 0.15;
                }
                else if (days > 15)
                {
                    cost -= cost * 0.2;
                }
            }

            if (feedback == "positive")
            {
                cost += cost * 0.25;
            }
            else if (feedback == "negative")
            {
                cost -= cost * 0.10;
            }

            Console.WriteLine($"{cost:f2}");

        }
    }
}


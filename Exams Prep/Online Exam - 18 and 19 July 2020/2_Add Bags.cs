using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggagePrice = double.Parse(Console.ReadLine());
            double luggageKg = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int luggageNum = int.Parse(Console.ReadLine());
            double price = 0.0;


            if (luggageKg < 10)
            {
                price += luggagePrice * 0.2;
                if (days < 7)
                {
                    price += price * 0.4;
                }
                else if (days >= 7 && days <= 30)
                {
                    price += price * 0.15;
                }
                else if (days > 30)
                {
                    price += price * 0.1;
                }
            }
            else if (luggageKg >= 10 && luggageKg <= 20)
            {
                price += luggagePrice * 0.5;
                if (days < 7)
                {
                    price += price * 0.4;
                }
                else if (days > 7 && days <= 30)
                {
                    price += price * 0.15;
                }
                else if (days > 30)
                {
                    price += price * 0.1;
                }
            }
            else if (luggageKg > 20)
            {
                price = luggagePrice;
                if (days < 7)
                {
                    price += price * 0.4;
                }
                else if (days >= 7 && days <= 30)
                {
                    price += price * 0.15;
                }
                else if (days > 30)
                {
                    price += price * 0.1;
                }
            }
            double total = price * luggageNum;
            Console.WriteLine($"The total price of bags is: {total:f2} lv.");
        }
    }
}



using System;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            double costStudio = 0.00;
            double costApartment = 0.00;

            if (month == "May" || month == "October")
            {
                costStudio = num * 50;
                costApartment = num * 65;
                if (num > 7 && num <= 14)
                {
                    costStudio -= costStudio * 0.05;
                }
                else if (num > 14)
                {
                    costStudio -= costStudio * 0.3;
                    costApartment -= costApartment * 0.1;
                }

            }
            else if (month == "June" || month == "September")
            {
                costStudio = num * 75.20;
                costApartment = num * 68.70;
                if (num > 14)
                {
                    costStudio -= costStudio * 0.2;
                    costApartment -= costApartment * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                costStudio = num * 76;
                costApartment = num * 77;
                if (num > 14)
                { 
                    costApartment -= costApartment * 0.1;
                }
            }
            
            Console.WriteLine($"Apartment: {costApartment:f2} lv.");
            Console.WriteLine($"Studio: {costStudio:f2} lv.");
        }
    }
}


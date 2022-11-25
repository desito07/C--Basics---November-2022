using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodQuantityTotal = double.Parse(Console.ReadLine());
            double sumDog = 0.0;
            double sumCat = 0.0;
            double sum = 0.0;
            double biscuits = 0.0;



            for (int i = 1; i <= days; i++)
            {
                double currentFoodDog = double.Parse(Console.ReadLine());
                double currentFoodCat = double.Parse(Console.ReadLine());

                sumDog += currentFoodDog;
                sumCat += currentFoodCat;
                sum += currentFoodDog + currentFoodCat;
                if (i % 3 == 0)
                {
                    biscuits += (currentFoodCat + currentFoodDog) * 0.1;

                }

            }

            Console.WriteLine($"Total eaten biscuits: {biscuits:f0}gr.");
            Console.WriteLine($"{sum / foodQuantityTotal * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{sumDog / sum * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{sumCat / sum * 100:f2}% eaten from the cat.");
        }
    }
}


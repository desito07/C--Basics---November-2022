using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerDay = int.Parse(Console.ReadLine());
            int numWalksPerday = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            double minTotal = minutesPerDay * numWalksPerday;
            double caloriesTotal = minTotal * 5;
            double calories50 = caloriesPerDay * 0.5;

            if(caloriesTotal >= calories50)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesTotal}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesTotal}.");
            }
        }
    }
}


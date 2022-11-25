using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumNeeded = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double cost = 0;

            if(gender == "m")
            {
                if(sport == "Gym")
                {
                    cost = 42;
                }
                else if(sport == "Boxing")
                {
                    cost = 41;
                }
                else if (sport == "Yoga")
                {
                    cost = 45;
                }
                else if (sport == "Zumba")
                {
                    cost = 34;
                }
                else if (sport == "Dances")
                {
                    cost = 51;
                }
                else if (sport == "Pilates")
                {
                    cost = 39;
                }
            }
            else if(gender == "f")
            {
                if (sport == "Gym")
                {
                    cost = 35;
                }
                else if (sport == "Boxing")
                {
                    cost = 37;
                }
                else if (sport == "Yoga")
                {
                    cost = 42;
                }
                else if (sport == "Zumba")
                {
                    cost = 31;
                }
                else if (sport == "Dances")
                {
                    cost = 53;
                }
                else if (sport == "Pilates")
                {
                    cost = 37;
                }
            }
            if(age <= 19)
            {
                cost -= cost * 0.2;
            }
            if(cost < sumNeeded)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport:f2}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${cost - sumNeeded:f2} more.");
            }
        }
    }
}


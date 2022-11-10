using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int durationEpizod = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());

            double lunch = durationBreak * 0.125;
            double relaxing = durationBreak * 0.25;

            double totalTime = durationBreak - lunch - relaxing;

            

            if (totalTime >= durationEpizod)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(totalTime - durationEpizod)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(durationEpizod - totalTime)} more minutes.");
            }


        }
    }

}
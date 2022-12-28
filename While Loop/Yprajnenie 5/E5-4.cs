using System;

namespace L4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsNeeded = 10000;
            int sumSteps = 0;

            while (true)
            {
                
                string input = Console.ReadLine();
                

                if(input == "Going home")
                {
                    sumSteps += int.Parse(Console.ReadLine());
                    break;
                }
               
                sumSteps += int.Parse(input);
                if(sumSteps >= stepsNeeded)
                {
                    break;
                }
            }
            if (sumSteps >= stepsNeeded)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.Write($"{sumSteps - stepsNeeded} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{stepsNeeded - sumSteps} more steps to reach goal.");
            }
        }
    }
}


using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totaltime = firstTime + secondTime + thirdTime;

            double totalTimeMin = totaltime / 60;
            double totalTimeSec = totaltime % 60;

            if (totalTimeSec < 10)
            {
                Console.WriteLine($"{totalTimeMin}:0{totalTimeSec}");
            }
            else
            {
                Console.WriteLine($"{totalTimeMin}:{totalTimeSec}");
            }
        }
    }

}

using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSecsPerMeter = double.Parse(Console.ReadLine());

            double swimmerTime = distanceMeters * timeSecsPerMeter;
            double delay = Math.Round(distanceMeters / 15 * 12.5);

            double swimmerTimeTotal = swimmerTime + delay;

            if(swimmerTime <= recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimmerTimeTotal:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(swimmerTimeTotal - recordTime):F2} seconds slower.");
            }

        }
    }

}
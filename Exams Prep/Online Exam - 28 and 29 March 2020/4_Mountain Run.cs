using System;


namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSecs = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSecsPerMeter = double.Parse(Console.ReadLine());

            double secsTotal = distanceMeters * timeSecsPerMeter;
            double delay = (Math.Floor(distanceMeters / 50)) * 30;
            double totalTime = (secsTotal + delay);



            if (recordSecs > totalTime)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - recordSecs:f2} seconds slower.");
            }
        }
    }
}


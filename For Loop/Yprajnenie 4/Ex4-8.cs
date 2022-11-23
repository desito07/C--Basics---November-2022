using System;

namespace For_Loop_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int toursNum = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double wonTours = 0;
            int currentPoints = 0;
           

            for (int i = 1; i <= toursNum; i++)
            {
                string stage = Console.ReadLine();
               
                if(stage == "W")
                {
                    currentPoints += 2000;
                    startPoints += 2000;
                    wonTours++;
                }
                else if(stage == "F")
                {
                    currentPoints += 1200;
                    startPoints += 1200;
                }
                else if (stage == "SF")
                {
                    currentPoints += 720;
                    startPoints += 720;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {currentPoints / toursNum}");
            Console.WriteLine($"{wonTours / toursNum * 100:f2}%");
        }
    }
}


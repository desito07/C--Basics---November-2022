
using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int excludedCounter = 0;
            int grade = 1;
            double sum = 0.0;

            while(grade <= 12)
            {

                double currentGrade = double.Parse(Console.ReadLine());
                

                if(currentGrade < 4)
                {
                    excludedCounter++;
                }
                if(excludedCounter == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade - 1} grade");
                    break;
                }

                sum += currentGrade;
                grade++;
            }
            double avg = sum / 12;
            if(excludedCounter < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avg:f2}");
            }
        }
    }
}

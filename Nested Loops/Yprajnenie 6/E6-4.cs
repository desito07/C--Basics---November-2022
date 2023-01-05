using System;

namespace Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int judgesCount = int.Parse(Console.ReadLine());
            double presentationsAvrGradesSum = 0;
            int presentationsCount = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "Finish")
                {
                    break;
                }

                presentationsCount++;

                double gradesSum = 0;

                for (int i = 0; i < judgesCount; i++)
                {
                    gradesSum += double.Parse(Console.ReadLine()); 
                }
                presentationsAvrGradesSum += gradesSum / judgesCount;
                Console.WriteLine($"{command} - {gradesSum / judgesCount:f2}.");
            }


            Console.WriteLine($"Student's final assessment is {presentationsAvrGradesSum / presentationsCount:f2}.");
        }
    }
}


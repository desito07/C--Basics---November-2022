using System;  

namespace L4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrades = int.Parse(Console.ReadLine());
            int counter = 0;
            string lastProblem = "";
            int solvedProblems = 0;
            double sum = 0.00;


            while (true)
            {
                string command = Console.ReadLine();
                

                if(command == "Enough")
                {
                    break;
                }
                lastProblem = command;
                solvedProblems++;
                int currentGrade = int.Parse(Console.ReadLine());
                sum += currentGrade;

                if (currentGrade <= 4)
                {
                    counter++;
                    
                }
                if(maxBadGrades == counter)
                {
                    break;
                }
               
            }

           
            if (maxBadGrades == counter)
            {
                Console.WriteLine($"You need a break, {counter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sum / solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}



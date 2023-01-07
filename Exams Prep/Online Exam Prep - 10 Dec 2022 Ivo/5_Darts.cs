using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            int startPoints = 301;
            int counterSuccess = 0;
            int counterNonSuccess = 0;


            string command = Console.ReadLine();


            while (command != "Retire")
            {

                int currentPoints = int.Parse(Console.ReadLine());

                if(command == "Single")
                {
                    currentPoints *= 1;
                }
                else if(command == "Double")
                {
                    currentPoints *= 2;
                }
                else if(command == "Triple")
                {
                    currentPoints *= 3;
                }

                if(currentPoints < startPoints)
                {
                    startPoints -= currentPoints;
                    counterSuccess++;
                }
                else if(currentPoints == startPoints)
                {
                    startPoints -= currentPoints;
                    counterSuccess++;
                    break;
                }
                else
                {
                    counterNonSuccess++;
                }


                command = Console.ReadLine();
                
            }

            if(command == "Retire")
            {
                Console.WriteLine($"{namePlayer} retired after {counterNonSuccess} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{namePlayer} won the leg with {counterSuccess} shots.");
            }
        }
    }
}



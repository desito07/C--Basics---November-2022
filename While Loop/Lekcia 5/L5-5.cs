using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0.0;

            while(command != "NoMoreMoney")
            {

                double commandNum = double.Parse(command);

                if (commandNum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {commandNum:f2}");

                sum += commandNum;

                command = Console.ReadLine();

                
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}

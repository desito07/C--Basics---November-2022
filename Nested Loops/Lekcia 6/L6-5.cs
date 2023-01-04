using System;

namespace Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double tripPrice = double.Parse(Console.ReadLine());
                double sum = 0.0;
                while (sum < tripPrice)
                {
                    double instalment = double.Parse(Console.ReadLine());
                    sum += instalment;
                }
                if(sum >= tripPrice)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
                destination = Console.ReadLine();
            }
            
        }
    }
}


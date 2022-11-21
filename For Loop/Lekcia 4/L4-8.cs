
using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersN = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int biggest = int.MinValue;

            for (int i = 0; i < numbersN; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if(currentNumber < smallest)
                {
                    smallest = currentNumber;
                }
                if(currentNumber >= biggest)
                {
                    biggest = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");

        }
    }
}

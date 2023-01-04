using System;

namespace Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numToPrintInRow = 1;
            int currentNumber = 1;

            while (currentNumber <= number)
            {
                for (int i = 0; i < numToPrintInRow; i++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;

                    if (currentNumber > number)
                    {
                        break;
                    }

                }

                Console.WriteLine();
                numToPrintInRow++;

            }
        }
    }
}


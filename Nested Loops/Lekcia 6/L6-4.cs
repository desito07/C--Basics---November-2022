using System;

namespace Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;

            for (int i = start; i <= final; i++)
            {
                for (int j = start; j <= final; j++)
                {
                    combinations++;
                    int sum = i + j;
                    if (sum == magic)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {sum})");
                        break;
                    }
                }
                if (isFound == true)
                {
                    break;
                } 
            }
            if (isFound == false)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magic}");
                
            }
        }
    }
}

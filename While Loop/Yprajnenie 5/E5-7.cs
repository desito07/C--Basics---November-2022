using System;

namespace L4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= num; i++)
            {

                int currentNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    leftSum += currentNum;
                }
                else
                {
                    rightSum += currentNum;
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {leftSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}



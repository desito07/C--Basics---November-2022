using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= num * 2; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i <= num)
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
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}

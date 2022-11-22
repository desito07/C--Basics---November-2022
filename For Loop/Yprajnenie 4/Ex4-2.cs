using System;

namespace For_Loop_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if( currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }


            }
            int sumWithoutMaxNumber = sum - maxNumber;
            if(sumWithoutMaxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNumber}");

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumWithoutMaxNumber - maxNumber)}");
            }
        }
    }
}

  
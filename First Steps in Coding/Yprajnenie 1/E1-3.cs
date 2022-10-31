using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int periodMonths = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double interestTotalSum = depositSum * interest / 100;
            double interestPerMonth = interestTotalSum / 12;

            double sum = depositSum + periodMonths * interestPerMonth;

            Console.WriteLine(sum);

        }

    }
}

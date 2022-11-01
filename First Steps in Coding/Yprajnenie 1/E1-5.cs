using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pensPackageNumber = int.Parse(Console.ReadLine());
            int highlitherPackageNumber = int.Parse(Console.ReadLine());
            int cleaningstuffPackageNumber = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pensCost = pensPackageNumber * 5.80;
            double lighlightersCost = highlitherPackageNumber * 7.20;
            double cleaningstuffCost = cleaningstuffPackageNumber * 1.20;
            double totalCost = pensCost + lighlightersCost + cleaningstuffCost;

            double totalPrice = totalCost - (totalCost * discount / 100);

            Console.WriteLine(totalPrice);
        }

    }
}

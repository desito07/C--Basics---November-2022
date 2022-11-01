using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualCostPerYear = int.Parse(Console.ReadLine());

            double shoes = annualCostPerYear - (annualCostPerYear * 0.4);
            double kit = shoes - (shoes * 0.2);
            double ball = kit * 1/4 ;
            double accesories = ball * 1/5;

            double costs = shoes + kit + ball + accesories + annualCostPerYear;

            Console.WriteLine(costs);
        }

    }
}

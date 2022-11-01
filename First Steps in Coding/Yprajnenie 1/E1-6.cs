using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonQuantityNeeded = int.Parse(Console.ReadLine());
            double paintQuantityNeeded = double.Parse(Console.ReadLine());
            int tinnerQuantityNeeded = int.Parse(Console.ReadLine());
            int hoursPainterNeeded = int.Parse(Console.ReadLine());

            double nylonCost = (nylonQuantityNeeded + 2) * 1.5;
            double paintCost = (paintQuantityNeeded + (paintQuantityNeeded * 10/100)) * 14.50;
            double tinnercost = tinnerQuantityNeeded * 5.00;

         
            double bags = 0.40;

            double materialsCost = nylonCost + paintCost + tinnercost + bags;



            double paintersLabour = (materialsCost * 30 / 100) * 8;

            double totalCost = materialsCost + paintersLabour;

            Console.WriteLine(totalCost);

        }

    }
}

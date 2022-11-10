using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double actorCostumePrice = double.Parse(Console.ReadLine());

            double actorsCosts = actors * actorCostumePrice;
            double decorCosts = budgetMovie * 0.1;

            if(actors > 150)
            {
                actorsCosts -= actorsCosts * 0.1;
            }

            double costs = actorsCosts + decorCosts;

            double diff = Math.Abs(costs - budgetMovie);

            if (costs >= budgetMovie)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {diff:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:F2} leva left.");
            }
        }
    }

}
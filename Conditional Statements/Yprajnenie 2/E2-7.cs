using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetRequired = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int rammemory = int.Parse(Console.ReadLine());

            double videocardCost = videocards * 250;
            double processorsCost = videocardCost * 0.35 * processors;
            double rammemoryCosts = videocardCost * 0.1 * rammemory;

            double costs = videocardCost + processorsCost + rammemoryCosts;



            if (videocards > processors)
            {
                costs -= costs * 0.15;
            }

            if (budgetRequired > costs)
            {
                Console.WriteLine($"You have {budgetRequired - costs:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {costs - budgetRequired:f2} leva more!");
            }
        }
    }
}
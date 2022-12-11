using System;

namespace Exam_111222
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatP = double.Parse(Console.ReadLine());
            double proteinsP = double.Parse(Console.ReadLine());
            double carbsP = double.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());
            double waterP = double.Parse(Console.ReadLine());


            double f = (fatP / 100 * calories) / 9;
            double p = (proteinsP / 100 * calories) / 4;
            double c = (carbsP / 100 * calories) / 4;

            double total = f + p + c;
            double caloriesPerGram = calories / total;
            double caloriesPerGramNet = caloriesPerGram * waterP / 100;
            double caloriesFinal = caloriesPerGram - caloriesPerGramNet;
            Console.WriteLine($"{caloriesFinal:f4}");


        }
    }
}


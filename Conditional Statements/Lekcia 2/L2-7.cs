using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;

            if (shape == "square")
            {
                double num1 = double.Parse(Console.ReadLine());
                area = num1 * num1;
                Console.WriteLine(Math.Round(area, 3)); ;
            }
            else if (shape == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double area1 = num1 * num2;
                Console.WriteLine(Math.Round(area1, 3));
            }
            else if (shape == "circle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double area2 = num1 * num1 * Math.PI;
                Console.WriteLine(Math.Round(area2, 3));
            }

            else if (shape == "triangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double area3 = (num1 * num2) / 2;
                Console.WriteLine(Math.Round(area3, 3));
            }

        }
    }
}


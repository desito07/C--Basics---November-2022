using System;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string screening = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;

            if(screening == "Premiere")
            {
                income = rows * columns * 12.00;
            }
            else if (screening == "Normal")
            {
                income = rows * columns * 7.5;
            }
            else if (screening == "Discount")
            {
                income = rows * columns * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}


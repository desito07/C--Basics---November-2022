using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 15;

            if(min >= 60)
            {
                hour++;
                min -= 60;
            }

            if (hour == 24)
            {
                hour = 0;
            }

            if ( min > 10)
            {
                Console.WriteLine($"{hour}:{min}");
            }
            else
            {
                Console.WriteLine($"{hour}:0{min}");
            }
        }
    }

}
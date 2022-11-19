using System;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string yperator = Console.ReadLine();

            double result = 0.00;

            if (yperator == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - odd");
                }
            }
            else if (yperator == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - odd");
                }
            }
            else if (yperator == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - odd");
                }
            }
            else if (yperator == "/")
            {
                if (num2 != 0)
                
                {
                    result = num1 / (num2 * 1.0);
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
            else if (yperator == "%")
            {
                if (num2 != 0)
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }

        }
    }
}


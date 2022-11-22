using System;

namespace For_Loop_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;
            double p5 = 0.00;

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    p1++;
                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    p2++;
                }
                else if (currentNum >= 400 && currentNum < 600)
                {
                    p3++;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    p4++;

                }
                else if (currentNum >= 800)
                {
                    p5++;
                }
            }
            Console.WriteLine($"{p1 / num * 100:f2}%");
            Console.WriteLine($"{p2 / num * 100:f2}%");
            Console.WriteLine($"{p3 / num * 100:f2}%");
            Console.WriteLine($"{p4 / num * 100:f2}%");
            Console.WriteLine($"{p5 / num * 100:f2}%");
        }
    }

}



using System;

namespace For_Loop_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

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
            Console.WriteLine($"{p1 * 1.0 / num * 100:f2}%");
            Console.WriteLine($"{p2 * 1.0 / num * 100:f2}%");
            Console.WriteLine($"{p3 * 1.0 / num * 100:f2}%");
            Console.WriteLine($"{p4 * 1.0 / num * 100:f2}%");
            Console.WriteLine($"{p5 * 1.0 / num * 100:f2}%");
        }
    }
    
}

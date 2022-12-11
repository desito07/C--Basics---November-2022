using System;

namespace Exam_111222
{
    class Program
    {
        static void Main(string[] args)
        {
            double UpFirst = double.Parse(Console.ReadLine());
            int UpSecond = int.Parse(Console.ReadLine());
            double UpThird = double.Parse(Console.ReadLine());

            for (int i = 2; i <= UpFirst; i += 2)
            {
                for (int j = 2; j <= UpSecond; j++)
                {
                    if (j == 2 || j == 3 || j == 5 || j == 7)
                    {
                        for (int r = 2; r <= UpThird; r += 2)
                        {
                            Console.WriteLine($"{i} {j} {r}");
                        }
                    }
                }
            }
        }
    }
}


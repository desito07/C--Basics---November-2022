using System;

namespace Exam_111222
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());
            double sum = 0.0;
            double kmP = km;


            for (int i = 1; i <= days; i++)
            {
                double currentKmP = double.Parse(Console.ReadLine());
                double currentKm = currentKmP / 100;


                kmP += currentKm * kmP;
                sum += kmP;
                //Console.WriteLine(sum);

            }
            double total = sum + km;
            if (total <= 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - total)} more kilometers");
            }
            else
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(Math.Abs(total - 1000))} more kilometers!");
            }



        }
    }
}


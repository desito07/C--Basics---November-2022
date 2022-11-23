using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double uan = double.Parse(Console.ReadLine());
            double commisson = double.Parse(Console.ReadLine());

            double usd = 1.76;
            double uanInUSD = uan * 0.15;

            double leva = bitcoin * 1168 + uanInUSD * 1.76;
            double euro = leva / 1.95;
            
            double total = euro * commisson / 100;
           
            Console.WriteLine($"{euro - total:f2}");
        }
    }
}


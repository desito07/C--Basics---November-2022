//using System;

//namespace MyApp // Note: actual namespace depends on the project name.
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello SoftUni");
//        }

//    }
//}

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMetersLandscaping = double.Parse(Console.ReadLine());

            double totalCostInclVAT = squareMetersLandscaping * 7.61;
            double discountedPrice = totalCostInclVAT * 0.18;

            double total = totalCostInclVAT - discountedPrice;

            Console.WriteLine($"The final price is: {total} lv.");
            Console.WriteLine($"The discount is: {discountedPrice} lv.");
        }

        
    }
}
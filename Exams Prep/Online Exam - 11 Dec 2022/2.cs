using System;
using System.Data;

namespace Exam_111222
{
    class Program
    {
        static void Main(string[] args)
        {
            double djobni = double.Parse(Console.ReadLine());
            double moneyPurchases = double.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double savedMoney = 5 * djobni;
            double wonMoney = 5 * moneyPurchases;
            double savedMoneyTotal = savedMoney + wonMoney;
            double left = savedMoneyTotal - expenses;


            if (left > presentPrice)
            {
                Console.WriteLine($"Profit: {left:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {presentPrice - left:f2} BGN.");
            }
        }
    }
}


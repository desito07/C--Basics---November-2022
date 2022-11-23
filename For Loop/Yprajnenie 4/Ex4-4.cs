using System;

namespace For_Loop_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPriceSingle = double.Parse(Console.ReadLine());
            double savings = 0;
            double money = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                   
                    savings += money;
                    money += 10;
                    savings--;
                }
                else
                {
                    savings += toyPriceSingle;
                }
            }
            if (savings >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savings - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - savings:f2}");
            }
        }
    }
}


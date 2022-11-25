using System;

namespace For_Loop_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());
            double groupMusala = 0.00;
            double groupMonblan = 0.00;
            double groupKilimandjaro = 0.00;
            double groupK2 = 0.00;
            double groupEverest = 0.00;
            double sum = 0;

            for (int i = 0; i < groupNum; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum <= 5)
                {
                    groupMusala += currentNum;
                    sum += currentNum;
                }
                else if (currentNum >= 6 && currentNum <= 12)
                {
                    groupMonblan += currentNum;
                    sum += currentNum;
                }
                else if (currentNum >= 13 && currentNum <= 25)
                {
                    groupKilimandjaro += currentNum;
                    sum += currentNum;
                }
                else if (currentNum >= 26 && currentNum <= 40)
                {
                    groupK2 += currentNum;
                    sum += currentNum;

                }
                else if (currentNum >= 41)
                {
                    groupEverest += currentNum;
                    sum += currentNum;
                }
            }
            Console.WriteLine($"{groupMusala / sum * 100:f2}%");
            Console.WriteLine($"{groupMonblan / sum * 100:f2}%");
            Console.WriteLine($"{groupKilimandjaro / sum * 100:f2}%");
            Console.WriteLine($"{groupK2 / sum * 100:f2}%");
            Console.WriteLine($"{groupEverest / sum * 100:f2}%");
        }
    }

}

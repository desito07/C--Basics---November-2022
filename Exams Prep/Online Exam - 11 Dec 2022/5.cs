using System;

namespace Exam_111222
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetProfit = int.Parse(Console.ReadLine());
            double profit = 0.0;
            double cost = 0.00;


            string command = Console.ReadLine();
            while (command != "closed" && true)
            {
                string type = Console.ReadLine();

                if (command == "haircut")
                {
                    if (type == "mens")
                    {
                        cost = 15;
                        profit += cost;
                    }
                    else if (type == "ladies")
                    {
                        cost = 20;
                        profit += cost;
                    }
                    else if (type == "kids")
                    {
                        cost = 10;
                        profit += cost;
                    }

                }
                if (command == "color")
                {
                    if (type == "touch up")
                    {
                        cost = 20;
                        profit += cost;

                    }
                    else if (type == "full color")
                    {
                        cost = 30;
                        profit += cost;
                    }
                }


                command = Console.ReadLine();
                if (targetProfit <= profit)
                {

                    Console.WriteLine($"You have reached your target for the day!");
                    break;

                }

            }


            if (targetProfit > profit)

            {
                Console.WriteLine($"Target not reached! You need {targetProfit - profit}lv. more.");

            }
            Console.WriteLine($"Earned money: {profit}lv.");
        }
    }
}

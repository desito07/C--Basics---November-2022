using System;

namespace L4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());
            int counter = 0;
            int spendingCounter = 0; 


            while (true)
            {
                string command = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());
                counter++;

                if (command == "save")
                {
                    moneyAvailable += currentMoney;
                    spendingCounter = 0;
                  
                }
                else if(command == "spend")
                {
                    moneyAvailable -= currentMoney;
                    spendingCounter++;
                    if (moneyAvailable < 0)
                    {
                        moneyAvailable = 0;
                    }
                }

               

                if(spendingCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(counter);
                    break;
                }

                if(moneyNeeded <= moneyAvailable)
                {
                    break;
                }
            }

            if (moneyNeeded <= moneyAvailable)
            {
                Console.WriteLine($"You saved the money for {counter} days.");
            }

        }
    }
}


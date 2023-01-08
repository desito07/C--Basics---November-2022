using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double allClientPrice = 0.0;

            for (int currentClient = 1; currentClient <= clients; currentClient++)
            {
                string currentProduct = Console.ReadLine();
                int count = 0;
                double price = 0;

                while (currentProduct != "Finish")
                {
                    if (currentProduct == "basket")
                    {
                        price += 1.50;
                        count++;
                    }
                    else if (currentProduct == "wreath")
                    {
                        price += 3.80;
                        count++;
                    }
                    else if (currentProduct == "chocolate bunny")
                    {
                        price += 7;
                        count++;
                    }
                    currentProduct = Console.ReadLine();
                }

                if (count % 2 == 0)
                {
                    price *= 0.80;
                }
                Console.WriteLine($"You purchased {count} items for {price:f2} leva.");
                allClientPrice += price;
            }
            double avg = allClientPrice / clients;
            Console.WriteLine($"Average bill per client is: {avg:f2} leva.");
        }

    }
}



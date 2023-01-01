using System;

namespace L4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int count = width * height;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    Console.WriteLine($"{count} pieces are left.");
                    break;
                }

                int piecesToTake = int.Parse(command);

                if (piecesToTake > count)
                {
                    Console.WriteLine($"No more cake left! You need {piecesToTake - count} pieces more.");
                    break;
                }

                count -= piecesToTake;

                if (count == 0)
                {
                    Console.WriteLine($"{count} pieces are left.");
                    break;
                }
            }
        }

    }
}



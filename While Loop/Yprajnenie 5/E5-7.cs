using System;

namespace L4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            int count = width * height * depth;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    Console.WriteLine($"{count} Cubic meters left.");
                    break;
                }

                int freeSpace = int.Parse(command);

                if (freeSpace > count)
                {
                    Console.WriteLine($"No more free space! You need {freeSpace - count} Cubic meters more.");
                    break;
                }

                count -= freeSpace;

                if (count == 0)
                {
                    Console.WriteLine($"{count} pieces are left.");
                    break;
                }
            }
        }

    }
}



using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeInLiters = volume / 1000;

            double spaceNeeded = volumeInLiters - (volumeInLiters * percentage / 100);

            Console.WriteLine(spaceNeeded);

        }

    }
}

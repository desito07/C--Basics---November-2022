using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while(command != "Stop")
            {
                Console.WriteLine(command);

                command = Console.ReadLine();
            }
        }
    }
}

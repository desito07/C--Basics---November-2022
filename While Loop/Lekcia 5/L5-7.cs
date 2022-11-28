using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double minNum = double.MaxValue;

            while (command != "Stop")
            {
                double commandNum = double.Parse(command);
                if (commandNum < minNum)
                {
                    minNum = commandNum;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(minNum);

        }
    }
}

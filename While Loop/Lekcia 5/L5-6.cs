using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double maxNum = double.MinValue;

            while(command != "Stop")
            {
                double commandNum = double.Parse(command);
                if (commandNum > maxNum)
                {
                    maxNum = commandNum;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(maxNum);

        }
    }
}

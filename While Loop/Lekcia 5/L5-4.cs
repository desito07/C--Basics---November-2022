using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            while(counter <= num)
            {
                Console.WriteLine(counter);
                counter = counter * 2 + 1;
                
            }
        }
    }
}

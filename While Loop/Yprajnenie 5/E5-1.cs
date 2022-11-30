using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace L4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int counter = 0;
            bool isFound = false;

            string currentBook = Console.ReadLine();

            while(currentBook != "No more Books")
            {
                if(currentBook == favBook)
                {
                    isFound = true;
                    break;
                }
                counter++;

                currentBook = Console.ReadLine();
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}



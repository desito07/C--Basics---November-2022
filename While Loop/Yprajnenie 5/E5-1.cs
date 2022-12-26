using System;
using System.Reflection;
using static System.Reflection.Metadata.BlobBuilder;

namespace L4_10
{
    class Program
    {
        static void Main(string[] args)
        {

            string wantedBook = Console.ReadLine();
            int counter = 0;

            bool isFound = false;
            while (true)
            {
                string command = Console.ReadLine();

                if(command == "No More Books")
                {
                    break;
                }

                if(command == wantedBook)
                {
                    isFound = true;
                    break;
                }
                counter++;
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




using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string colour = "";

            int counter = int.MinValue;
            int countRed = 0;
            int countOrange = 0;
            int countBlue = 0;
            int countGreen = 0;


            for (int i = 1; i <= num; i++)
            {
                string currentcolor = Console.ReadLine();
                if(currentcolor == "red")
                {
                    countRed++;
                    if (countRed > counter)
                    {
                        counter = countRed;
                        colour = "red";

                    }
                }
                else if(currentcolor == "orange")
                {
                    countOrange++;
                    if (countOrange > counter)
                    {
                        counter = countOrange;
                        colour = "orange";
                    }
                }
               else if(currentcolor == "green")
                {
                    countGreen++;
                    if (countGreen > counter)
                    {
                        counter = countGreen;
                        colour = "green";
                    }
                } 
                else if(currentcolor == "blue")
                {
                    countBlue++;
                    if (countBlue > counter)
                    {
                        counter = countBlue;
                        colour = "blue";
                    }
                }
            }
            Console.WriteLine($"Red eggs: {countRed}");
            Console.WriteLine($"Orange eggs: {countOrange}");
            Console.WriteLine($"Blue eggs: {countBlue}");
            Console.WriteLine($"Green eggs: {countGreen}");
            Console.WriteLine($"Max eggs: {counter} -> {colour}");
        }
    }
}


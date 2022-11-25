using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string red = "";
            string orange = "";
            string yellow = "";
            string white = "";
            string black = "";
            string other = "";
            int counterRed = 0;
            int counterOrange = 0;
            int counterYellow = 0;
            int counterWhite = 0;
            int counterBlack = 0;
            int counterOther = 0;
            

            int sumPoints = 0;


            for (int i = 1; i <= num; i++)
            {
                string colourBall = Console.ReadLine();
                switch (colourBall)
                {
                    case "red": sumPoints += 5; counterRed++; break;
                    case "orange": sumPoints += 10; counterOrange++; break;
                    case "yellow": sumPoints += 15; counterYellow++; break;
                    case "white": sumPoints += 20; counterWhite++; break;
                    case "black": sumPoints /= 2; counterBlack++; break;
                    default: counterOther++; break;
                }
               
            }
            Console.WriteLine($"Total points: {sumPoints}");
            Console.WriteLine($"Red balls: {counterRed}");
            Console.WriteLine($"Orange balls: {counterOrange}");
            Console.WriteLine($"Yellow balls: {counterYellow}");
            Console.WriteLine($"White balls: {counterWhite}");
            Console.WriteLine($"Other colors picked: {counterOther}");
            Console.WriteLine($"Divides from black balls: {counterBlack}");
        }
    }
}


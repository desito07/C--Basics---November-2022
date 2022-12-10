//using System;

//namespace Exams_Prep
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int timeScreening = int.Parse(Console.ReadLine());
//            int scenes = int.Parse(Console.ReadLine());
//            int durationScene = int.Parse(Console.ReadLine());

//            double prepTeren = Math.Ceiling(timeScreening * 0.15);
//            double totalTimescenes = scenes * durationScene;

//            double totalTime = prepTeren + totalTimescenes;

//            if(timeScreening < totalTime) {
//                Console.WriteLine($"Time is up! To complete the movie you need {totalTime - timeScreening} minutes.");
//            }
//            else
//            {
//                Console.WriteLine($"You managed to finish the movie on time! You have {timeScreening - totalTime} minutes left!");
//            }
//        }
//    }
//}


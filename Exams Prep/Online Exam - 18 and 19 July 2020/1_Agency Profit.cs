using System;

namespace Exams_Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameAircompany = Console.ReadLine();
            int numTicketAdult = int.Parse(Console.ReadLine());
            int numTicketChild = int.Parse(Console.ReadLine());
            double priceAdult = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double ticketChild = priceAdult - priceAdult * 0.7;
            double ticketAdultWithCom = priceAdult + commission;
            double ticketChildwithCom = ticketChild + commission;

            double total = numTicketAdult * ticketAdultWithCom + ticketChildwithCom * numTicketChild;

            double profit = total * 0.20;

            Console.WriteLine($"The profit of your agency from {nameAircompany} tickets is {profit:f2} lv.");

        }
    }
}


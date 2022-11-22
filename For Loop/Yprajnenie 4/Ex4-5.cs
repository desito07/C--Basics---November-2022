using System;
using System.Collections.Generic;

namespace For_Loop_Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsNum = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
           
            

            for (int i = 0; i < tabsNum; i++)
            {
                string website = Console.ReadLine();
                if(website == "Facebook")
                {
                    salary -= 150;
                }
                else if(website == "Instagram")
                {
                    salary -= 100;
                }
                else if(website == "Reddit")
                {
                    salary -= 50;
                }
            }
            if(salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
            
        }
    }
}

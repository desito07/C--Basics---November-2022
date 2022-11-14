using System;
using System.Runtime.Intrinsics.X86;

namespace Conditional_Statements_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0; 

            bool inValid = false;

            if (city == "Sofia")
            {
                if(sales <= 500 && sales >= 0)
                {
                    commission = sales * 0.05;
                }
                else if(sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (sales <= 500 && sales >= 0)
                {
                    commission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.1;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales <= 500 && sales >= 0)
                {
                    commission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    commission = sales * 0.145;
                }
            }

            if((city == "Sofia" || city == "Varna" || city == "Plovdiv") && (commission > 0))
            {
                Console.WriteLine($"{commission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
                
        }
    }
}


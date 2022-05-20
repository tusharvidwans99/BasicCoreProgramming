using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class Flipcoin
    {

        public static void FliptheCoin()
        {
            Console.Write("Enter the value for number of flips: ");
            int Head = 0;
            int Tail = 0;
            int Headcount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int flipcoin = Convert.ToInt32(Console.ReadLine());

            if(flipcoin > 0)
            {
                for(int i = 0; i <= flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.Write(number);
                    if(number == 1)
                    {
                        Headcount++;
                    }
                    else
                    {
                        TailCount++;
                    }
                    
                }
            }
            Console.Write("Headcount:" + Headcount + " Tailcount: " + TailCount);
            HeadPercentage = (double)Headcount / flipcoin * 100;
            TailPercentage = (double)TailCount / flipcoin * 100;

            Console.WriteLine("HeadPercentage: "+HeadPercentage);
            Console.WriteLine("TailPercentage: "+TailPercentage);

        }

    }
}

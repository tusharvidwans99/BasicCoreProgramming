using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class PrimeFactors
    {
        public static void checkPrimeFactors()
        {
            Console.Write("Enter the number for getting prime factors: ");
            int num = Convert.ToInt32(Console.ReadLine());

            
            if(num == 0 || num == 1 || num < 0)
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                for(int i = 2; i <= num; i++)
                {
                    while (num % i == 0)
                    {
                        Console.WriteLine(i);
                        num = num/i;
                    }
                }
            }
          
        }
    }
}

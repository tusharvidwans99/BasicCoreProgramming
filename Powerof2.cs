using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class Powerof2
    {
        public static void powerof2()
        {
            Console.WriteLine("Enter the number between 1-32: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number > 31)
            {
                Console.WriteLine("Invalid Number, Enter between 1-32");
            }
            else
            {
                for(int i = 1; i <= number; i++)
                {
                    Console.WriteLine($"2^{i}: " + Math.Pow(2,i));
                }
                 
            }
        }
    }
}

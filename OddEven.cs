using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class OddEven
    {

        public static void isOddorEven()
        {

            Console.WriteLine("Enter the Number to check it is Even or Odd: ");
            int number= Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }

        }

    }
}

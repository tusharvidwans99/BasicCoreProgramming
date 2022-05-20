using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class LeapYear
    {

        public static void isLeapYear()
        {
            Console.Write("Enter the Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                Console.WriteLine(year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }
        }

    }
}

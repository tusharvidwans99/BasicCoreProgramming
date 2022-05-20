using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    class SumAndAverage
    {

        public static void sumavg()
        {
            int a = 67;
            int b = 52;
            int sum = a + b;
            float Average = (float)sum / 2;

            Console.WriteLine($"Sum of {a} & {b} is: " + sum);
            Console.WriteLine($"Average of {a} & {b} is: "+Average);
            
        }

    }
}

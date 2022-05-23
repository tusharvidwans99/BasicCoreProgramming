using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class printingPattern
    {
        public static void createPattern()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
               
            }
        }
    }
}

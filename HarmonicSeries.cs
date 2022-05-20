using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class HarmonicSeries
    {
        public static void Harmonic()
        {

            Console.Write("Enter the number to generate Harmonic series: ");
            int num = Convert.ToInt32(Console.ReadLine());
            String Harmonics = "Hn=1/1";
            double HarmonicsValue = 1;

            if(num > 0)
            {
                for (int i = 2; i <= num; i++)
                {
                    Harmonics = Harmonics + $"+1/{i}";
                    HarmonicsValue += (double) 1 / i;
                }
                Console.WriteLine("Calculating Nth Harmonic value of: " + Harmonics);
                Console.WriteLine("=> "+HarmonicsValue);
            }
            else
            {
                Console.WriteLine("Invalid number, Enter number greater than 0");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class isPalindrome
    {
        public static void checkPalindrome()
        {

            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            int check=0;
            while(first != 0)
            {
                int remainder = first % 10;
                check = check * 10 + remainder;
                first = first / 10;
            }
            
            if(check == second)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("It is not Palindrome");
            }
        }
    }
}

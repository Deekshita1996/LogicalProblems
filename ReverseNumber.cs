using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class ReverseNumber
    {
        public static void GetNumber()
        {
            int n, rev = 0;
            Console.WriteLine("Enter any number: ");
            n = int.Parse(Console.ReadLine());
            int reverse = 0;
           
            while (n > 0)
            {
                var remainder = n % 10;
                 reverse = (reverse * 10) + remainder;
                n = n / 10;
            }
            Console.WriteLine("Reverse No. is {0}", reverse);

            
        }
    }
}
  

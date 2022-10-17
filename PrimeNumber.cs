using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PrimeNumber
    {
        public static void PrimeNo()
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter the number: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    Console.WriteLine("Number is not a prime number");
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is a prime number");
        }

    }
}

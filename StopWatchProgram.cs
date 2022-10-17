using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalproblems
{
    public class stopwatchprogram
    {
        public static void elapsetime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1);
            }
            stopwatch.Stop();
            Console.WriteLine("time elapsed: {0}", stopwatch.Elapsed);
            Console.WriteLine(Console.ReadKey());
        }
    }
}

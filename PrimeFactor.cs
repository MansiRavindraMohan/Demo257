using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class PrimeFactor
    {
        public static void FactorPrime()
        {
            int n, i;
            Console.WriteLine("Enter the Number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors:");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

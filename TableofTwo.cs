using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace HelloWorld
{
    class TableofTwo
    {
        public static void PowerofTwo()
        {
            Console.WriteLine("Powers of 2 till 2^30");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            int num = 1;
            for (var i = 0; i <= 30; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}
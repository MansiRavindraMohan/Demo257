using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Harmonic
    {
        public static void numberharmonic()
        {
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(" +1/" + i + " ");
                }
        }
    }
}




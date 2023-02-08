using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class flipCoin
    {
        public static void CalculatePercentage()
        {
            Console.WriteLine("Please enter the value for number of flips");

            int head = 0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;

            double HeadPercent;
            double TailPercent;

            int flipCoin=Convert.ToInt32(Console.ReadLine());

            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    Console.WriteLine("The Random number generated is " + number);
                    if (number == 0)
                    {
                        Console.WriteLine("Tail");
                        tailcount++;
                    }
                    else
                    {
                        Console.WriteLine("Head");
                        headcount++;
                    }
                }
                Console.WriteLine("The tail count is " + tailcount);
                Console.WriteLine("The head count is " + headcount);

                HeadPercent = headcount * 100 / flipCoin;
                TailPercent= tailcount * 100 / flipCoin;

                Console.WriteLine("HeadPercent : " + HeadPercent+ "%");
                Console.WriteLine("TailPercent : " + TailPercent+ "%");

            }
            else 
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}

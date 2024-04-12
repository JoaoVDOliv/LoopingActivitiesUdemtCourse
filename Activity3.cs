using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingExercirsms
{
    internal class Activity3
    {
        public static void process()
        {
            int summedValues = 0;

            for (int i = 1; i <= 10; i++)
            { 
                summedValues += i;
                Console.Write($" {i} ");
            }

            Console.WriteLine($"The sum of the first 10 naturals numbers is {summedValues}");
        }
    }
}

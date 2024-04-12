using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingExercirsms
{
    internal class Activity4
    {
        public static void process()
        {
            for (int i = 1; i <= 6; i++) 
            {
                for(int j = 1; j <= 6; j++)
                {
                    if (i / j == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine(" ");
            }
        }
    }
}

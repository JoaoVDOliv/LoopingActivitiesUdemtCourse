﻿using System;
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
            for (int i = 0; i < 5; i++) 
            {
                for(int j = 0; j < 5; j++)
                {
                    if (j <= i)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingExercirsms
{
    internal class Activity1
    {
        int number1 { get; set; }
        int number2 { get; set; }         
        int number3 { get; set; }

        public Activity1()
        {
            Console.WriteLine("This is a simple activity about see the biggest number");
            Console.WriteLine("Please, write 3 numbers:");
            Console.WriteLine("Number 1: ");            
            number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Number 2: ");            
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 3: ");
            number3 = Convert.ToInt32(Console.ReadLine());
        }

        public void process()
        {
            Console.WriteLine($"The biggest number is {this.compareNumbers()}");
        }

        private int compareNumbers()
        {
            int biggestNum = 0;

            if ((number1 > number2) && (number1 > number3))
            {
                biggestNum = number1;
            }
            else if ((number2 > number1) && (number2 > number3))
            {
                biggestNum = number2;
            }
            else if ((number3 > number1) && (number3 > number1))
            {
                biggestNum = number3;
            }
            else
            {
                Console.WriteLine("Are you jocking with me???");
            }

            return biggestNum;
        }
    }
}

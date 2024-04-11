using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopingExercirsms
{   
    internal class Activity2
    {
        protected int valueA { get; set; }
        protected int valueB { get; set; }
        protected int valueC { get; set; }
        private int deltaValue { get; set; }
        private int rootOne { get; set; }
        private int rootTwo { get; set; }
        

        public Activity2 ()
        {
            Console.WriteLine("This activity is about to calculate a second second degree function (Baskara)");
            Console.WriteLine("Considering the second degree function ax^2+bx+c, pass 3 values to a, b and c");
            Console.WriteLine("Value A: ");
            valueA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value B: ");
            valueB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value C: ");
            valueC = Convert.ToInt32(Console.ReadLine());
        }

        public void process()
        {
            deltaValue = this.calcDelta();

            Console.WriteLine($"The value a = {valueA}");
            Console.WriteLine($"The value b = {valueB}");
            Console.WriteLine($"The value c = {valueC}");

            if (this.calcPlusRoot() && this.calcLessRoot())
            {
                Console.WriteLine("Booth roots are reals and differents");
                Console.WriteLine($"Reulst of first root = {rootOne}");
                Console.WriteLine($"Reulst of first root = {rootTwo}");
            }   
            else
            {
                Console.WriteLine("Roots are imaginaries");
                Console.WriteLine("There are no solution to real numbers");
            }
        }

        private int calcDelta()
        {            
            return (valueB * valueB) - (4 * (valueA * valueC));
        }

        private bool calcPlusRoot()
        {
            double root = (-valueB + Math.Sqrt(deltaValue)) / (2 * valueA);

            if (root >= int.MinValue && root <= int.MaxValue && root == Math.Truncate(root))
            {
                rootOne = Convert.ToInt32(root);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool calcLessRoot()
        {
            double root = (-valueB - Math.Sqrt(deltaValue)) / (2 * valueA);

            if (root >= int.MinValue && root <= int.MaxValue && root == Math.Truncate(root))
            {
                rootTwo = Convert.ToInt32(root);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

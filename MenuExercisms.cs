using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingExercirsms
{
    internal class MenuExercisms
    {
        public void options()
        {
            int option = 0;
            
            Console.WriteLine("Welcome to my exercisms from Udemy course .NET");            

            do
            {
                Console.WriteLine("Choose a option:");
                Console.WriteLine("--------------------------");
                Console.WriteLine("0-Exit");
                Console.WriteLine("1-Activitie about ot read the biggest number");
                Console.WriteLine("--------------------------");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option) 
                {                
                    case 0:
                        Console.WriteLine("good bye");
                        
                        break;
                    case 1:
                        
                        Activity1 activity1 = new Activity1();
                        activity1.process();

                        break;
                    default:
                        Console.WriteLine("Please, choose beetwen the options!");
                        
                        break;
                }

            } while (option != 0);
        }
    }
}

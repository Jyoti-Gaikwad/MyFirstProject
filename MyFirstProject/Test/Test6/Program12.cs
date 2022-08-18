using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test6
{
    class Program12
    {
       
        static void Main(string[] args)
        {
            int buzz = 0, fizz = 0, buzzfizz = 0;
            int n = 50;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                    buzz++;
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz" + " ");
                    fizz++;
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {

                    Console.WriteLine("BuzzFizz"+" ");
                    buzzfizz++;
                }
                else
                {
                    Console.WriteLine(i);
                }

                
            }
            Console.WriteLine("Buzz: " + buzz);
            Console.WriteLine("Fizz: " + fizz);
            Console.WriteLine("BuzzFizz: " + buzzfizz);
           
        }
    }

    
}


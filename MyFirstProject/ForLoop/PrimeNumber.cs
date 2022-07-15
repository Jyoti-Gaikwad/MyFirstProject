using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ForLoop
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isprime = true;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    isprime = false;
                }
            }
            if(isprime==true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");

            }
        }
    }
}

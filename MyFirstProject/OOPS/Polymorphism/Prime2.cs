using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Polymorphism
{
    class Prime2
    {
        bool CheckPrime(int num)
        {
            bool isprime = true;
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    isprime = false;
                    break;
                }
               
            }
            return isprime;
        }
        static void Main(string[] args)
        {
            Prime2 p = new Prime2();
           bool b= p.CheckPrime(13);
            if(b==true)
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

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Polymorphism
{
    class Prime
    {
        bool CheckPrime(int num )
        {
            bool isprime= true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
            

        }


        static void Main(string[] args)
        {
            Prime p = new Prime();
           bool ans= p.CheckPrime(7);
            if(ans==true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}

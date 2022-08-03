using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Polymorphism
{
    class Prime1
    {
        bool IsPrime(int n)
        {
            bool isprime = true;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    isprime = false;
                    return false;
                    break;
                }
                else
                {
                    return true;
                }
            }
            return isprime;
        }
        static void Main(string[] args)
        {
            Prime1 p = new Prime1();
            Console.WriteLine(p.IsPrime(7));
            
            bool ans = p.IsPrime(6);
            Console.WriteLine(ans);
            
            bool Ans = p.IsPrime(11);
            Console.WriteLine("" + Ans);

            bool A = p.IsPrime(12);
            Console.WriteLine("" + A);
        }
    }
}

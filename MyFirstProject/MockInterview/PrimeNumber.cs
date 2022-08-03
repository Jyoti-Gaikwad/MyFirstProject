using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MockInterview
{
    class PrimeNumber
    {

        int CheckPrime(int n)
        {
            bool isprime = true;
            int num;
            for (int i=1;i<=n;i++)
            {
                num = i;
               
                for(int j=2;j<num;j++)
                {
                    if(num%j==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime==true)
                {
                    return num;
                }
            }
            return n;
            
        }
        static void Main(string[] args)
        {
            PrimeNumber p = new PrimeNumber();
                int ans = p.CheckPrime(20);
            Console.WriteLine(ans);

        }
        
    }


}
        
    


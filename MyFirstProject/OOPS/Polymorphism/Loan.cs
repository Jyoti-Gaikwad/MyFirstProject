using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Polymorphism
{
    class Loan
    {
        float CalculateLoan(int P,float R,int T)
        {
            float loan;
            return loan = (float)P * R * T;
        }
        float CalculateLoan(int P,float R1,float R2,int T)
        {
            float loan1;
            if (T <= 6)
            {
                
                return loan1 = (float)P * R1 * T;
            }
            else
            {
                return loan1 = (float)P * R2 * T;
            }
        }

        static void Main(string[] args)
        {
            Loan l = new Loan();
            Console.WriteLine(l.CalculateLoan(10000, 12f, 3));
           Console.WriteLine( l.CalculateLoan(10000, 2f, 5f, 6));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ForLoop
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            int n, r, temp;
            int sum = 0;

            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());

            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                    n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MockInterview
{
    class FLDigitSum
    {
        static void Main(string[] args)

        {
            int sum = 0;
            int lastdigit;
            int firstdigit;
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            lastdigit = num % 10;
            while (num>10)
            {
                
                num = num / 10;
            }
             firstdigit = num;
            sum = firstdigit + lastdigit;
            Console.WriteLine("Sum=" + sum);
        }
    }
}

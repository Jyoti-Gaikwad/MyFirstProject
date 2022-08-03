using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MockInterview
{




    class DigitSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (num > 0)

            {
                int r = num % 10;
                num = num / 10;

                if (r % 2 == 0)
                {
                    sum = sum + r;
                    
;               }
            }
            Console.WriteLine("Sum="+sum);
        }
          
       
    }
}

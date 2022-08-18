using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.MockInterview
{
    class SumofEven
    {
        static void Main(string[] args)
        {
            int Sum = 0;
           

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {

                    Sum = Sum + i;
                }

            }
            Console.WriteLine("Sum of Even numbers=" + Sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class EvenSum
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if(i%2==0)
                {
                    
                    Sum = Sum +i;
                   
                    
                   
                   
                }
                
            }
            Console.WriteLine("Sum=" + Sum);
        }
    }
}

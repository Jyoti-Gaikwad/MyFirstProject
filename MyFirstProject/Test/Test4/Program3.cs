using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test4
{
    class Program3
    {
         static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a Number:: ");
            int n = Convert.ToInt32(Console.ReadLine());

          
            if (IsKaprekar(n))
                Console.WriteLine(n+" is a kaprekar number");
            else
                Console.WriteLine(n + " is not a kaprekar number");
            Console.ReadLine();
        }

        public static bool IsKaprekar(int num)
        {
            
            int square = 0;
            int temp = 0;
            int count = 0;
            int firstPart = 0;
            int secondPart = 0;
            int sum = 0;

            square = num* num;
            
            temp = square;
            while (temp != 0)
            {
                count++;
                temp = temp/10;
            }

           
            for (int i = count - 1; i > 0; i--)
            {
                
                firstPart = square / (int)Math.Pow(10, i);
                
                secondPart = square % (int)Math.Pow(10, i);

                if (firstPart == 0 || secondPart == 0)
                    continue;

                sum = firstPart + secondPart;

                if (sum == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}



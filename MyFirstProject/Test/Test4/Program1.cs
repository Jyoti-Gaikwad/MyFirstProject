using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Test.Test4
{
    class Program1
    {
          static int frequencyDigits(long n,int d)
        {

            int count= 0;
            while (n > 0)
            {
                if (n % 10 == d)
                count++;
                n = n / 10;
            }
            return count;
        }

        
        static public void Main(String[] args)
        {
            
           
            long N = 8080979286;

           
            int D = 8;
            int D1 = 0;
            int D2 = 9;
            int D3 = 7;
            int D4 = 2;
            int D5 = 6;
            

            Console.WriteLine("Frequency of digit 8: "+frequencyDigits(N, D));
            Console.WriteLine("Frequency of digit 0: "+frequencyDigits(N, D1));
            Console.WriteLine("Frequency of digit 9: " + frequencyDigits(N, D2));
            Console.WriteLine("Frequency of digit 7: " + frequencyDigits(N, D3));
            Console.WriteLine("Frequency of digit 2: " + frequencyDigits(N, D4));
            Console.WriteLine("Frequency of digit 6: " + frequencyDigits(N, D5));

        }
    }

   
    
}

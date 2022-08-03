
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.XaobinTest
{
    class Average
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;double count =0;
            double avg=0;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
                count++;
            }
           avg =sum / count;
            Console.WriteLine(avg);

        }

    }
}

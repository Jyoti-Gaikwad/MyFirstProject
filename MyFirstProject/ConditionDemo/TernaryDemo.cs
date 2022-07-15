using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ConditionDemo
{
    class TernaryDemo
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }

            //condition?true part:false part
            /*   int result=  num1 > num2 ? num1 : num2;
                  Console.WriteLine("Result    "+result);*/

            string ans = num1 > num2 ? "Num1 is greater" : "Num2 is greater";
            Console.WriteLine(ans);

        }
    }
}

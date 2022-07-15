using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ForLoop
{
    class AutomorphicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(CheckAutomorphicNumber(num))
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }
            Console.ReadLine();
        }
        public static bool CheckAutomorphicNumber(int num)
        {
            int square = num * num;
            while(num>0)
            {
                if(num%10!=square%10)
                {
                    return false;
                }
                num = num / 10;
                square = square / 10;
            }
            return true;
        }
    }
}


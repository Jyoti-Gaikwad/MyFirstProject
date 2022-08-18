using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class MaxChar
    {
        public static char FindMax(char[] ch)
        {
            char Max = ch[0];
            for(int i=0;i<ch.Length;i++)
            {
                if(Max<ch[i])
                {
                    Max = ch[i];
                }
            }
            return Max;
        }
         static void Main(string[] args)
        {
            char[] c = { 'a', 'b', 'U', 'c', 'R' };
            char maxValue = MaxChar.FindMax(c);
            Console.WriteLine("Maximum character from array: " + maxValue);
        }
    }
}

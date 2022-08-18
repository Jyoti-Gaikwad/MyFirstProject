using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Array
{
    class Minchar
    {
        public static char FindMin(char[] ch)
        {
            char Min = ch[0];
            for (int i = 0; i < ch.Length; i++)
            {
                if (Min > ch[i])
                {
                    Min = ch[i];
                }
            }
            return Min;
        }
        static void Main(string[] args)
        {
            char[] c = { 'a', 'b', 'd', 'c', 'e' };
            char minValue = Minchar.FindMin(c);
            Console.WriteLine("Maximum character from array: " + minValue);
        }

    }
}

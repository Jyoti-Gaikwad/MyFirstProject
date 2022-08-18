using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PENA4
{
    class TotalLetter
    {
        public static void Main()
        {
            string str;
            int i, wrd, l;

           
            Console.Write("Enter the text : ");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

            
            while (l <= str.Length - 1)
            {
                
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Total number of letters in the text is : {0}\n", l);
        }
    }
}


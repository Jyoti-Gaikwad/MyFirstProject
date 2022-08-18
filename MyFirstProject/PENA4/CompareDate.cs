using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PENA4
{
    class CompareDate
    {
        public static void Main()
        {
            DateTime date1 = new DateTime(2010, 1,1, 4, 0, 15);

           
            DateTime date2 = new DateTime(2010, 1,1, 4, 0, 14);

            
            int value = DateTime.Compare(date1, date2);

            
            if (value > 0)
                Console.Write("date2 is earlier than date1. ");
            else if (value < 0)
                Console.Write("date1 is earlier than date2. ");
            else
                Console.Write("date1 is the same as date2. ");
        }
    }
}


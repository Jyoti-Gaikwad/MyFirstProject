﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Switch
{
    class Switch4
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter Day Number");
            int dayno = Convert.ToInt32(Console.ReadLine());

            switch(dayno)
            {
                case 1:Console.WriteLine("Day Name : Sunday");
                    break;

                case 2:Console.WriteLine("Day Name : Monday");
                    break;

                    case 3: Console.WriteLine("Day Name : Tuesday");
                    break;

                case 4: Console.WriteLine("Day Name : Wednesday");
                    break;

                case 5: Console.WriteLine("Day Name : Thursday");
                    break;

                case 6: Console.WriteLine("Day Name : Friday");
                    break;

                case 7: Console.WriteLine("Day Name : Saturday");
                    break;
            }
        }
    }
}

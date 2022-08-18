using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.PENA4
{
    class TimeSpan1
    {
        static void Main()
        {
            TimeSpan time;

            TimeSpan ts1 = new TimeSpan(10, 20, 50);
            TimeSpan ts2 = new TimeSpan(8, 19, 32);

            time = ts1 + ts2;

            Console.WriteLine("Hours:{0}, Minutes:{1}, Seconds:{2}", time.Hours, time.Minutes, time.Seconds);


        }
    }
}

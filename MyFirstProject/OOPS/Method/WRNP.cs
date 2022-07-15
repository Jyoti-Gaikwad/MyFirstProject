using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Method
{
    class WRNP
    {
        public int AreaRectangle()
        {
            int a = 5 * 4;
            return a;
        }
        static void Main(string[] args)
        {
            WRNP w = new WRNP();
            int Area=w.AreaRectangle();
            Console.WriteLine("Arae=" + Area);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Static
{
    class StaticMethod
    {
       
        static int Addition()
        {
            return 2 + 5;
        }
        static void Main(string[] args)
        {
            StaticMethod m = new StaticMethod();
            int ans = StaticMethod.Addition();
            Console.WriteLine("Addition:" + ans);
        }
    }
}

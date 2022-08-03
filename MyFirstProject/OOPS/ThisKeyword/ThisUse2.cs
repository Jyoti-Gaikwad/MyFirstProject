using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.ThisKeyword
{
    class ThisUse2
    {
        public void input()
        {
            Console.WriteLine("Input Method");
            this.show();
        }
        public void show()
        {
            Console.WriteLine("Show Method");
        }
        static void Main(string[] args)
        {
            ThisUse2 t = new ThisUse2();
            t.input();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Method
{
    class NRNP
    {
        public void show()
        {
            Console.WriteLine("Show Method");
        }
        static void Main(string[] args)
        {
            NRNP n = new NRNP();
            n.show();
        }
    }
    
}

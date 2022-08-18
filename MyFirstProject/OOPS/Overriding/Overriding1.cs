using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Overriding
{
    class Fruit
    {
        public virtual void Test()
        {
            Console.WriteLine("Test is sweet");
        }
    }
    class Mango:Fruit
    {
        public override void Test()
        {
            Console.WriteLine("Mango is sweet");
            base.Test();
        }
    }
    class Banana:Fruit
    {
        public override void Test()
        {
            Console.WriteLine("Banana is sweet");
            base.Test();
        }
    }
    class Overriding1
    {
       static void Main(string[] args)
        {
            Fruit f = new Mango();
            f.Test();
            Fruit f2 = new Banana();
            f2.Test();
        }
    }
}

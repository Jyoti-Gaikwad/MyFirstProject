using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Abstraction
{
    abstract class mathoperation
    {
        public int a = 58;
    }
    interface IAddable
    {

         static int b = 30;
       
    }
    
   
    class Addition:mathoperation
    {
        public int add()
        {
            return a + IAddable.b;
        }
    }
    class AbstractInterface
    {
        static void Main(string[] args)
        {
            Addition m = new Addition();
           Console.WriteLine("Addition:"+m.add());
        }
    }
}

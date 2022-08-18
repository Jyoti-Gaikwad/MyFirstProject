using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class TV
    {
        public string color = "Black";
        public TV(int price)
        {
            Console.WriteLine("Price:"+price);
        }     
        public void Size()
        {
            Console.WriteLine("Size is 43 inch");
        }
    }
    
    class LCD : TV
    {
        public string color = "Silver";
        public LCD() : base(1000)
        { 
        }
            public void show()
            {
                Console.WriteLine("LCD Color: " + color + "\nTV Color: " + base.color);
                Console.WriteLine("Size of LCD is 32 inch\n");
            }
        
    }
    class LEDTV : TV
    {
        public LEDTV() : base(2000)
        {
        }
             public void display()
            {
                Console.WriteLine("LEDTV Color:" + base.color);

                base.Size();
            }
        
    }
    class BaseKeyword
    {
        static void Main(string[] args)
        {
            LCD L = new LCD();
            L.show();
            LEDTV L1 = new LEDTV();
            L1.display();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.ThisKeyword
{
    class Gadget
    {

        public int price = 2500;
       public string Type;
        public Gadget(string Type)
        {
            this.Type = Type;
            Console.WriteLine("Type of Watch:" + Type);
            
            
        }
        public void Show()
        {
            Console.WriteLine("Gadget: Watch");
            
        }
      
       
    }
    class watch : Gadget
    {
        private string type;

        public watch(string type) : base("Smart Watch")
        {
            this.type= type;
        }

        public watch() : this("Analog Watch")
        {

            Console.WriteLine("Types of watch:" + type);
        }


        public void show()
        {
            base.Show();
            Console.WriteLine("Price of Watch:" + base.price+"\n");

            this.Show();
        }
       

    }
    class BaseThis
    {
        static void Main(string[] args)
        {
            watch w = new watch();
             w.show();
            
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Contentment
{
    class Engine
    {
        string Enginetype;

        public Engine(string E)
        {
            this.Enginetype = E;
        }
        public void show()
        {
            Console.WriteLine(" " + Enginetype);
            
        }
    }
    class Car
    {
        int modelno;
        string name;
        int price;
        Engine En;

        public Car(int m, string n, int p, Engine e)
        {
            this.modelno = m;
            this.name = n;
            this.price = p;
            this.En = e;

        }
        public void display()
        {
            Console.WriteLine(" " + modelno + " " + name + " " + price);
            En.show();
        }

        static void Main(string[] args)
        {
            Engine E1 = new Engine("Petrol");
            Car c = new Car(206, "Alto", 400000, E1);
            c.display();


        }



    }
}

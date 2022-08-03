using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Contentment
{
    class Engine2
    {
        string engineType;

        public string Engine
        {
            get { return engineType; }
            set { engineType = value; }
        }
    }
    class Car2
    {
        int modelno;
        string name;
        int price;
        Engine2 e;

        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Engine2 E
        {
            get { return e; }
            set { e = value; }
        }
    }
    class CarInfo
    {
        static void Main(string[] args)
        {
            Car2 c2 = new Car2();
            c2.Modelno = 102;
            c2.Name = "Creta";
            c2.Price = 1500000;
            c2.E = new Engine2();
            c2.E.Engine = "Petrol";
            Console.WriteLine(" " + c2.Modelno + " " + c2.Name + " " + c2.Price + " " + c2.E.Engine);
        }

    }

}

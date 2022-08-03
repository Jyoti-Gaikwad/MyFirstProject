using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Encapsulation
{
    class Car
    {
        private int modelno;
        private string name;
        private string color;
        private double price;
        private double speed;

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
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
        class CarInfo
        {
            static void Main(string[] args)
            {
                Car c = new Car();
                c.Modelno = 234;
                c.Name = "Swift";
                c.Color = "White";
                c.Price = 600000;
                c.Speed = 120;
            Console.WriteLine("Car Model Number:" + c.Modelno);
            Console.WriteLine("Car Name:" + c.Name);
            Console.WriteLine("Car color:" + c.Color);
            Console.WriteLine("Car Price:" + c.Price);
              Console.WriteLine("Car Speed:" + c.Speed);
            }
        }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Encapsulation
{
    class Car2
    {
        int model_no;
        string name;
        int price;
        int speed;


        public int ModelNo
        {
            get
            {
                return model_no;
            }
            set
            {
                model_no = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }


    }
    class Car3
    {
        static void Main(string[] args)
        {
            Car2 c = new Car2();
            c.ModelNo = 7699;
            c.Name = "Creta";
            c.Price = 1500000;
            c.Speed = 120;
            Console.WriteLine("Model Number:" +c.ModelNo);
            Console.WriteLine("Car NAme: " + c.Name);
            Console.WriteLine("Price:" + c.Price);
            Console.WriteLine("Speed:" + c.Speed);
        }
    }
}

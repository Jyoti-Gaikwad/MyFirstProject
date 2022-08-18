using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Contentment
{
    class Pen
    {
        public int length;
        public string name;
        public string color;
        public string type;

        public int Length
        {
            get { return length; }
            set { length = value; }
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
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Bag
    {
        string bagname;
        int price;
        string color;
        Pen pen;

        public string Bagname
        {
            get { return bagname; }
            set { bagname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }

        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
       public  Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }
    }
    class BagInfo
    {
        static void Main(string[] args)
        {
           
            Bag b = new Bag();
            b.Bagname = "school bag";
            b.Color = "Blue";
            b.Price = 450;
            b.Pen = new Pen();
            b.Pen.Length = 5;
            b.Pen.Name = "Nataraj";
            b.Pen.Color = "blue";
            b.Pen.Type = "jel Pen";
            Console.WriteLine("Bagname:"+b.Bagname+"\nBag Color:"+b.Color+"\nBag Price:"+b.Price+"\n");
            Console.WriteLine("Pen Lenght:" + b.Pen.Length + "\nPen Name:" + b.Pen.Name + "\nPen Color:" + b.Pen.Color +
                "\nPen Type:" + b.Pen.Type);
        }
    }
}

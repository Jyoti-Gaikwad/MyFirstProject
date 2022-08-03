using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Contentment
{
    class Address
    {
        public int pincode;
        public string cityname;

        public Address(int p, string c)
        {
            this.pincode = p;
            this.cityname = c;
        }
        public void Show()
        {
            Console.WriteLine(" " + pincode + " " + cityname);
        }
    }
    class PersonAddress
    {
        int id;
        string name;
        Address adr;

        public PersonAddress(int i, string n, Address a)
        {
            this.id = i;
            this.name = n;
            this.adr = a;
        }
        void Display()
        {
            Console.WriteLine(" " + id + " " + name);
            adr.Show();
        }

        static void Main(string[] args)
        {
            Address a1 = new Address(414302, "Panoli");
            PersonAddress p = new PersonAddress(1, "Jyoti", a1);
            p.Display();
        }
    }
}
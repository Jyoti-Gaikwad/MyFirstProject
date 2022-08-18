using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Inheritance
{
   class vegetables
    {
        internal string name;
       

        public void show(string N)

        {
            name = N;
           
        }
    }
    class LeafyVegetables:vegetables
    {
        internal int price;
        public void Show(int p)
        {
            price = p;
           
        }
    }

    class Spinach:LeafyVegetables
    {
        internal string weight;
        public void show1(string w)
        {
            weight = w;
            Console.WriteLine("Vegetable Name: "+name + "\nPrice: " + price + "\nWeight: " + weight);
        }
    }
    class Multilevel
    {
        static void Main(string[] args)
        {
            Spinach s = new Spinach();
            s.show("Spinach");
            s.Show(100);
            s.show1("1kg");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Class_And_Object
{
    class Car
    {
        int ModelNo;
        string CarName;
        int price;

        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.ModelNo = 301;
            c1.CarName = "Swift";
            c1.price = 900000;

            Car c2 = new Car();
            c2.ModelNo = 108;
            c2.CarName = "Alto";
            c2.price = 500000;

            Car c3 = new Car();
            c3.ModelNo = 205;
            c3.CarName = "I20";
            c3.price = 1000000;

            Console.WriteLine(c1.ModelNo + "\n" + c1.CarName + "\n" + c1.price + "\n");
            Console.WriteLine(c2.ModelNo + "\n" + c2.CarName + "\n" + c2.price+"\n");
            Console.WriteLine(c3.ModelNo + "\n" + c3.CarName + "\n" + c3.price);
        }
    }
}

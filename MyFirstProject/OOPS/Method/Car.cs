using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.Method
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

            Console.WriteLine(c1.ModelNo + "\n" + c1.CarName + "\n" + c1.price+"\n");
            Console.WriteLine(c2.ModelNo + "\n" + c2.CarName + "\n" + c2.price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.XaobinTest
{
    class SellingPrice
    {
        int costprice;
        int noofitems;
        int profit;
        public void AcceptDetails(int cs,int noi,int p)
        {
            costprice = cs;
            noofitems = noi;
            profit = p;
        }
        public float Calculate_sellingPrice()
        {
           
            double sp = ((costprice + 100) * profit) / 100;
            return (float)sp;
        }
            
        
        public void display()
        {
            Console.WriteLine(costprice + "\n" + noofitems + "\n" + profit);
        }
        static void Main(string[] args)
        {

            SellingPrice s = new SellingPrice();
            s.AcceptDetails(20,10,20);
            s.display();

            double sp = s.Calculate_sellingPrice();
            Console.WriteLine(sp);
        }
        
    }
}

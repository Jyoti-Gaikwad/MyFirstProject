using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.ThisKeyword
{
    class Shopping
    {
        int purchase_item;
        string quantity;
        int itemPrice;

        public void AcceptDetails(int pi,string q,int ip)
        {
            purchase_item = pi;
            quantity = q;
            itemPrice = ip;
            

        }
        public void getbill()
        {

        }
        public void showbill()
        {

        }
        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.AcceptDetails(2, "2kg", 200);
            s.getbill();
            s.showbill();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.LoopsTest2
{
    class Order
    {
        int order_id;
        string cust_name;
        bool isdelivered = true;

        public int OrderId
        {
            get { return order_id; }
            set { order_id = value; }

        }
        public string Name
        {
            get { return cust_name; }
            set { cust_name = value; }

        }
        public bool IsDelivered
        {
            get { return isdelivered; }
            set { isdelivered = value; }
        }
    }
    class order
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.OrderId = 101;
            o.Name = "Jyoti";
            
            o.IsDelivered = true;
            Console.WriteLine("Order id:" + o.OrderId + "\n" + "Customer Name:" + o.Name + "\n" 
                +  "IsDelivered:" + o.IsDelivered);
        }
    }
}

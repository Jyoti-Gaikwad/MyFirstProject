using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS.AccessModifier
{
    class Bank
    {
        int AccountNo;
        string Name;
        int Balance;
        int WithdrawAmount;
        int DepositeAmount;
        int CurrentBalance;
        public void AssignValue(int An,string name,int balance,int WA,int DA)
        {
            AccountNo = An;
            Name = name;
            Balance = balance;
           
            WithdrawAmount = WA;
            DepositeAmount = DA;
          //  CurrentBalance = CA;
        }
       
        public void Withdraw()
        {
            
            if (Balance < WithdrawAmount)
            {
                Console.WriteLine("Something is wromg");
            }
            else
            {
                Console.WriteLine("Withdraw Amount:" + WithdrawAmount);
                CurrentBalance = Balance - WithdrawAmount;
                Console.WriteLine("Current Balance:" + CurrentBalance+"\n");
            }
        }
        public int Deposite()
        {
           
            
           return CurrentBalance + DepositeAmount;
          
           this.display();
           
            
        }
        public void display()
        {
            Console.WriteLine("Account Number:" + AccountNo);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Balance:" + Balance);
            Console.WriteLine("CurrentBalance:" + (CurrentBalance + DepositeAmount));
            
            
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.AssignValue(10127551, "Jyoti Gaikwad", 20000, 15000, 3000);
            b.display();
          //  int CurrentBalance = b.Deposite();
            //Console.WriteLine("CurrentBalance" + CurrentBalance);
            b.Withdraw();
            b.Deposite();
            b.display();
           

        }
    }
}

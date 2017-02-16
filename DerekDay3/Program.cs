using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DerekDay3
{
    //Derek Workshop3-4: Bank Account

    public class BankTest2
    {
        public static void Main(string[] args)
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            //Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            Account a1 = new Account("001-001-001", y, 2000);
            //Account b1 = new Account("001-001-002", z, 5000);
            Console.WriteLine(a1.CalculateInterest());
            //Console.WriteLine(b1.CalculateInterest());
            Console.WriteLine(y.GetAge());
            //Console.WriteLine(z.GetAge());

            
            OverDraftAccount a2 = new OverDraftAccount("01230124", y, -2000);
            Console.WriteLine(a2.CalculateInterest());
            Console.WriteLine(a2.Show());

            CurrentAccount a3 = new CurrentAccount("01230125", y, 2000);
            Console.WriteLine(a3.CalculateInterest());
            Console.WriteLine(a3.Show());

            SavingAccount a4 = new SavingAccount("01230163", y, 4000);
            Console.WriteLine(a4.CalculateInterest());
            Console.WriteLine(a4.Show());
        }
    }
}
    

    

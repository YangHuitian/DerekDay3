using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekDay3
{
    //class BankTest
    //{
        //static void Main(string[] args)
        //{
            //Account a = new Account("001-001-001", "Tan Ah Kow", 2000);
            //Account b = new Account("001-001-002", "Kim Keng Lee", 5000);
            //Console.WriteLine(a.Show());
            //Console.WriteLine(b.Show());
            //a.Deposit(100);
            //Console.WriteLine(a.Show());
            //a.Withdraw(200);
            //Console.WriteLine(a.Show());
            //a.TransferTo(300, b);
            //Console.WriteLine(a.Show());
            //Console.WriteLine(b.Show());
        //}
    //}

    class BankTest2
    {
        static void Main(string[] args)
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            Account a = new Account("001-001-001", y, 2000);
            Account b = new Account("001-001-002", z, 5000);
            Console.WriteLine(y.GetAge());
            Console.WriteLine(z.GetAge());
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
        }
    }

    class Account
    {
        string AccountNumber;//attributes
        Customer AccountHolderName;
        double Balance;

        //constructor
        public Account(string AccountNumber, Customer AccountHolderName, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balance;
        }

        
        public void TransferTo(double amount, Account another)//method1-TransferTo
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                another.Deposit(amount);
            }
                
            else
                Console.WriteLine("You cannot transfer anymore.");
        }

        
        public double Show()//method2-Show
        {
            return Balance; 
        }

        public void Withdraw(double amount)//method3-Withdraw
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
            }
            else
                Console.WriteLine("You cannot withdraw anymore.");
        }

        public void Deposit(double amount)//method4-Deposit
        {
            Balance = Balance + amount;
        }
    }

    class Customer
    {
        string Name;//attributes
        string Address;
        string PassportNumber;
        DateTime DateOfBirth;

        //constructor
        public Customer(string Name, string Address, string PassportNumber, DateTime DateOfBirth)
        {
            this.Name = Name;
            this.Address = Address;
            this.PassportNumber = PassportNumber;
            this.DateOfBirth = DateOfBirth;
        }

        public int GetAge()//method1-getage: no need to put parameter/argument
        {
            DateTime n = DateTime.Now;
            int age = n.Year - DateOfBirth.Year;

            if (n.Month < DateOfBirth.Month || (n.Month == DateOfBirth.Month && n.Date < DateOfBirth.Date))
                age -= 1;
            return age;
        }
    }
}

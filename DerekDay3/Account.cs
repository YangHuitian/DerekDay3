﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekDay3
{
    public class Account
    {
        protected string AccountNumber;//attributes
        protected Customer AccountHolderName;
        protected double Balance;

        //constructor
        public Account(string Number, Customer HolderName, double Bal)
        {
            AccountNumber = Number;
            AccountHolderName = HolderName;
            Balance = Bal;
        }
        public Account()
            : this("000-000-000", new Customer(), 0){
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

        //properties
        public Customer ShowAccountHolderName
        {
            get
            {
                return AccountHolderName;
            }
        }
        public string ShowAccountNumber
        {
            get
            {
                return AccountNumber;
            }
        }
        public double ShowBal
        {
            get
            {
                return Balance;
            }
        }

        public virtual string Show()//method2-Show
        {
            return (String.Format("[Account] AccountNumber:{0}; AccountHolderName: {1}, Balance: {2}", AccountNumber, AccountHolderName.Show(), Balance));
        }

        public bool Withdraw(double amount)//method3-Withdraw
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                return true;
            }
            else
            {
                Console.WriteLine("You cannot withdraw anymore.");
                return false;
            }

        }

        public void Deposit(double amount)//method4-Deposit
        {
            Balance = Balance + amount;
        }

        public virtual double CalculateInterest()//method5-CalculateInterest
        {
            return 0;//not using any rate
        }
        public void CreditInterest()//method6-CreditInterest
        {
            Deposit(CalculateInterest());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DerekDay3
{
    public class BankBranch
    {
        string BranchName;
        string BranchManager;
        ArrayList BankAccounts;

        //Cons
        public BankBranch(string BrNa, string BrMa)
        {
            BranchName = BrNa;
            BranchManager = BrMa;
            BankAccounts = new ArrayList();
        }

        
        public void AddAccount(Account obj)//me1
        {
            BankAccounts.Add(obj);
        }

        public void PrintAccountsNum()//me2
        {
            for (int i = 0; i< BankAccounts.Count; i++)
            {
                Account a = (Account)BankAccounts[i];
                string b = a.ShowAccountNumber;
                Console.Write(b + "\t");
            }
            Console.WriteLine();
        }

        public void PrintCustomers()//me3//???
        {
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                Account a = (Account)BankAccounts[i];//第二级
                Customer b = a.ShowAccountHolderName;//第三级
                string c = b.Show();
                Console.Write(c+ "\t");
            }
            Console.WriteLine();
        }

        public double TotalDeposits()//me4
        {
            double TotalBal = 0;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                Account a = (Account)BankAccounts[i];
                if (a.ShowBal > 0)
                    TotalBal += a.ShowBal;
            }
            return TotalBal;
        }

        public double TotalInterestPaid()//me5
        {
            double Totalintopay = 0;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                Account a = (Account)BankAccounts[i];//??diff accounts???
                if (a.CalculateInterest() > 0)
                    Totalintopay += a.CalculateInterest();
                    //Console.WriteLine(Totalintopay); //just for check
            }
            return Totalintopay;
        }

        public double TotalInterestEarned()//me6
        {
            double Totalintoearn = 0;
            for (int i = 0; i < BankAccounts.Count; i++)
            {
                Account a = (Account)BankAccounts[i];
                if (a.CalculateInterest() < 0)
                    Totalintoearn += a.CalculateInterest();
            }
            return Totalintoearn;
        }

        
    

    }
}


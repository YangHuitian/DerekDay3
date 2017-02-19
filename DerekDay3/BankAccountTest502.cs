using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekDay3
{
    class BankAccountTest502
    {
        public static void Main()
        {
            BankBranch branch = new BankBranch("KOKO Bank Branch","Tan Mon Nee");
            Customer cus1 = new Customer("Tan Ah Kow", "2 Rich Street", "P345123", 40);
            Customer cus2 = new Customer("Lee Tee Kim", "88 Fatt Road","P678678", 54);
            Customer cus3 = new Customer("Alex Gold", "91 Dream Cove","P333221", 34);
            branch.AddAccount(new SavingAccount("S1230123", cus1, 2000));//20
            branch.AddAccount(new OverDraftAccount("O1230124", cus1, 2000));//5
            branch.AddAccount(new CurrentAccount("C1230125", cus2, 2000));//5
            branch.AddAccount(new OverDraftAccount("O1230126", cus3, -2000));
            branch.PrintCustomers();
            branch.PrintAccountsNum();
            Console.WriteLine("TotalInterestEarned: {0}", branch.TotalInterestEarned());
            Console.WriteLine("TotalInterestPaid: {0}",branch.TotalInterestPaid());
            //branch.CreditInterest();
            //branch.TotalDeposits();//6000
            Console.WriteLine("TotalDeposits: {0}",branch.TotalDeposits());
        }
    }
}

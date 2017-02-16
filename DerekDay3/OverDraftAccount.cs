using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekDay3
{
    public class OverDraftAccount : Account
    {
        //constructor
        double interestrate = 0.0025;
        double interestover = 0.06;
        public OverDraftAccount(string AccountNumber, Customer AccountHolderName, double Balance) : base(AccountNumber, AccountHolderName, Balance) { }

        public override string Show()//new method1-childclass2
        {
            return (String.Format("[OverDraftAccount] AccountNumber:{0}; AccountHolderName: {1}, Balance: {2}", AccountNumber, AccountHolderName.Show(), Balance));
        }

        public new void Withdraw(double amount)//new method2-childclass2
        {
            Balance -= amount;
        }

        public new double CalculateInterest()//new method3-childclass2
        {
            if (Balance >= 0)
                return Balance * interestrate;
            else//interestover
                return Balance * interestover;
        }


    }
}

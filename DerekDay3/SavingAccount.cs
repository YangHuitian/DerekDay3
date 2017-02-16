using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekDay3
{
    class SavingAccount : Account
    {
        //constructor
        public SavingAccount(string AccountNumber, Customer AccountHolderName, double Balance) : base(AccountNumber, AccountHolderName, Balance) { }

        public new double CalculateInterest()//new method1-childclass1
        {
            return 0.01 * Balance;
        }
        public override string Show()//new method2-Show-childclass1
        {
            return (String.Format("[SavingAccount] AccountNumber:{0}; AccountHolderName: {1}, Balance: {2}", AccountNumber, AccountHolderName.Show(), Balance));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekDay3
{
    class CurrentAccount : Account
    {
        //constructor
        public CurrentAccount(string AccountNumber, Customer AccountHolderName, double Balance) : base(AccountNumber, AccountHolderName, Balance) { }

        public override string Show()//new method1-Show-childclass2
        {
            return (String.Format("[CurrentAccount] AccountNumber:{0}; AccountHolderName: {1}, Balance: {2}", AccountNumber, AccountHolderName.Show(), Balance));
        }

        public override double CalculateInterest()//new method2-childclass2
        {
            return 0.0025 * Balance;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekDay3
{
    public class Customer
    {
        public string Name;//attributes
        string Address;
        string PassportNumber;
        DateTime DateOfBirth;
        int age;

        //constructor
        public Customer(string Name, string Address, string PassportNumber, DateTime DateOfBirth)
        {
            this.Name = Name;
            this.Address = Address;
            this.PassportNumber = PassportNumber;
            this.DateOfBirth = DateOfBirth;

        }
        public Customer(string Name, string Address, string PassportNumber, int age)
        {
            this.Name = Name;
            this.Address = Address;
            this.PassportNumber = PassportNumber;
            this.age = age;
        }
        public Customer()
            : this("Thisname", "ThisAddress", "ThisPassport", new DateTime(1980, 1, 1)) { }

        public int GetAge()//method1-getage: no need to put parameter/argument
        {
            DateTime n = DateTime.Now;
            int age = n.Year - DateOfBirth.Year;

            if (n.Month < DateOfBirth.Month || (n.Month == DateOfBirth.Month && n.Date < DateOfBirth.Date))
                age -= 1;//按阳历，精确到date
            return age;
        }

        public string Show()//Show name
        {
            return string.Format("{0}", Name);
        }
    }
}

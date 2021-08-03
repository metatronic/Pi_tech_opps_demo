using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Current:Bank
    {

        double overdraftAmount;
        double OverdraftAmount
        {
            get { return overdraftAmount; }
            set { overdraftAmount = value; }
        }
        public Current()
        {

        }

        public Current(string name, double amt, double overdraft) : base(name, amt)
        {
            this.OverdraftAmount = overdraft;
        }

        public override void Withdraw(double amount)
        {
            if ((base.Balance + this.OverdraftAmount - amount) >= 0)
            {
                base.Balance -= amount;
            }
            else
            {
                throw new BalanceException("Overdraft amount exceed");
            }
        }
    }
}

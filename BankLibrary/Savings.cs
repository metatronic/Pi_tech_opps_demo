using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Savings:Bank,IInterest
    {
        public Savings()
        {

        }

        public Savings(string name, double amt) : base(name, amt)
        {

        }

        public double CalculateInterest()
        {
            return Balance * .1;
        }

        public override void Withdraw(double amount)
        {
            if((base.Balance - amount) >= 0)
            {
                base.Balance -= amount;
            }
            else
            {
                throw new BalanceException("Balance not enough") ;
            }
        }
    }
}

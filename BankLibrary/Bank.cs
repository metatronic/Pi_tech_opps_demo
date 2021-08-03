using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public abstract class Bank
    {
        private static int accountNumberCount;

        public int accountNumber;
        public int AccountNumber
        {
            get { return accountNumber; }
            private set { accountNumber = value; }
        }
        private double balance;
        //mixed access specifier
        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }
        private string accountHolderName;
        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public abstract void Withdraw(double amount);

        public override string ToString()
        {
            return string.Format($"Account Number: {AccountNumber} Account Holder Name: {AccountHolderName} , Balance : {Balance}");
        }

        public Bank()
        {
            accountNumberCount++;
            AccountNumber = accountNumberCount;
            Balance = 1000;
        }
        public Bank(string name, double amount):this()
        {
            this.AccountHolderName = name;
            this.Balance = amount;
        }
    }
}

using BankLibrary;
using System;

namespace SBIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bank code
            //Bank bank = new Bank();
            //bank.AccountHolderName = "Pran";
            //bank.Deposit(20000);
            //Console.WriteLine(bank);
            //Console.WriteLine("Balance :"+bank.Balance);

            //bank.Deposit(1000);
            //Console.WriteLine("After Deposit: "+bank);

            //bank.Withdraw(200);
            //Console.WriteLine("After Withdraw: "+bank);

            //Bank bank2 = new Bank();
            //bank2.AccountHolderName = "Pratik";
            //Console.WriteLine(bank2);
            #endregion

            //Savings saving = new Savings("Pran", 20000);
            Current current = new Current("Pran", 20000, 100000);
            Console.WriteLine(current);
            try
            {
                //saving.Withdraw(50000);
                current.Withdraw(120001);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Bank bank = new Savings();
            bank.Withdraw(100);
            bank = new Current();
            bank.Withdraw(50);
            Console.WriteLine(current);



            Savings saving = new Savings("Pran", 50000);
            Console.WriteLine(saving.CalculateInterest());
            Console.ReadLine();


        }
    }
}

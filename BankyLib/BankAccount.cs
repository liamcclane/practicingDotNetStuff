using System;
using System.Collections.Generic;


namespace BankyLib
{
    public class BankAccount
    {
        // attributes
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (Transaction t in allTransactions)
                {
                    balance += t.Amount;
                }
                return balance;
            }
        }
        public List<Transaction> allTransactions = new List<Transaction>();

        // class specific attrubutes 
        // for creating a new account number
        private static int AccountNumberSeed = 1234;
        // constructors
        public BankAccount(string name, decimal initalBalance)
        {
            Owner = name;
            Number = AccountNumberSeed.ToString();
            MakeDeposit(initalBalance, "Starting balance");
            AccountNumberSeed++;
        }

        // Methods
        public void MakeDeposit(decimal amount, string note)
        {
            if (amount <= 0) { throw new ArgumentOutOfRangeException(nameof(amount), "Amount deposit must be positive"); }
            Transaction t = new Transaction(amount, DateTime.Now, note);
            allTransactions.Add(t);
        }
        public void MakeWithdrawl(decimal amount, string note)
        {
            if (amount <= 0) { throw new ArgumentOutOfRangeException(nameof(amount), "Amount withdrawl must be positive"); }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            Transaction t = new Transaction(-amount, DateTime.Now, note);
            allTransactions.Add(t);
        }
        public BankAccount PrintAllTransactions()
        {
            PrintInfo();
            Console.WriteLine($"Date\t\tAmount\tNote");
            foreach (Transaction t in allTransactions)
            {
                t.Print();
            }
            return this;
        }
        public BankAccount PrintInfo()
        {
            Console.WriteLine($"****{Owner}***{Number}");
            Console.WriteLine($"Total Balance: {Balance}");
            return this;
        }
    }
}

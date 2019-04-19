using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    public class BankAccount
    {
        //In this tutorial, the bank account supports this behavior:
        //It has a 10-digit number that uniquely identifies the bank account.
        //It has a string that stores the name or names of the owners.
        //The balance can be retrieved.
        //It accepts deposits.
        //It accepts withdrawals.
        //The initial balance must be positive.
        //Withdrawals cannot result in a negative balance.
        public static int accountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            MakeDeposit(initialBalance, new DateTime(2019, 01, 01), "Initial balance.");
        }

        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <=0)
            {
                throw new ArgumentOutOfRangeException("Amount of withdrawal must be positive");
            }

            if (Balance - amount <0)
            {
                throw new InvalidOperationException("Not sufficient fund for withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal );
        }
    }

    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }
    }
}

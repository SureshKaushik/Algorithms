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

        BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public int Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }

    }

    public class Transaction
    {
        public decimal Amount { get; set; }

    }
}

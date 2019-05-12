using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountChangeCategory
{
    class Account
    {
        const decimal depositLimit = 5000;
        const decimal withdrawLimit = depositLimit;
        public string CustomerName { get; private set; }
        public decimal Balance { get; private set; }
        public int NumberOfTransactions { get; private set; }

        public bool Deposit(decimal amount)
        {
            if (amount <= depositLimit &&
                amount >= 1)
            {
                Balance += amount;
                NumberOfTransactions++;
                return true;
            }

            return false;

        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= Balance &&
                amount <= withdrawLimit &&
                amount >= 1)
            {
                Balance -= amount;
                NumberOfTransactions++;
                return true;
            }

            return false;
        }

        public Account(string customerName)
        {
            this.CustomerName = customerName;
        }
        public override string ToString()
        {
            return "Account owner: " + CustomerName + " Balance: " + Balance + " Number of transactions: " + NumberOfTransactions;
        }
    }
}

using System;

namespace BankAccountChangeCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimitris = new Account("Dimitris");

            var trump = new StoreAccount("Kostas");
            SuccesfulWithdrawal(trump.Withdraw(100), trump);
            SuccessfulDeposit(trump.Deposit(500), trump);
            SuccessfulDeposit(trump.Deposit(500), trump);
            SuccessfulDeposit(trump.Deposit(5001), trump);
            SuccessfulDeposit(trump.Deposit(4500), trump);

            SuccesfulWithdrawal(dimitris.Withdraw(200), dimitris);
            SuccessfulDeposit(dimitris.Deposit(500), dimitris);
            SuccessfulDeposit(dimitris.Deposit(200), dimitris);
            SuccesfulWithdrawal(dimitris.Withdraw(150), dimitris);

            Category(trump, AccountCategoryId.Basic);
            Category(trump, AccountCategoryId.Lead);
            Category(trump, AccountCategoryId.Senior);


            Console.ReadLine();
        }

        public static void Category(StoreAccount account, AccountCategoryId category)
        {
            if (account.ChangeCategory(category))
            {
                Console.WriteLine($"Eligible for category change to {category}");
            }
            else
            {
                Console.WriteLine($"Not eligible for category change to {category}");
            }
        }

        static void SuccesfulWithdrawal(bool success, Account account)
        {
            if (success)
            {
                Console.WriteLine($"Withdrawal successful!\nNew balance for customer {account.CustomerName} is: {account.Balance}\nNumber of transactions: {account.NumberOfTransactions}");
            }
            else
            {
                Console.WriteLine("Withdrawal failed, unsufficient funds or sum over withdrawal limit!");
            }
        }

        static void SuccessfulDeposit(bool success, Account account)
        {
            if (success)
            {
                Console.WriteLine($"Deposit successful!\nNew balance for customer {account.CustomerName} is: {account.Balance}\nNumber of transactions: {account.NumberOfTransactions}");
            }
            else
            {
                Console.WriteLine("Deposit failed, sum over deposit limit");
            }
        }
    }
}
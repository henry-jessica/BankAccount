using System;
using System.Collections.Generic;
using System.Text;


namespace Bank
{
    class BankAccount
    {
        // private attribures/members/instances fileds
        private string accountCustomerName;
        private string accountType;
        private int bIC;
        private int accountNumber; //This should be unique for all objects of type BankAccount.
        private double balance;
        private int accountPIN;


        //default constructor
        public BankAccount()
        {
            //transaction is unique
        }

        // encapsulating 
        public string AccountCustomerName { get { return accountCustomerName; } set { accountCustomerName = value; } }
        public string AccountType
        {
            get { return accountType; }
            set
            {
                if (value == "current" || value == "deposit" || value == "savings")
                {
                    accountType = value;
                }
                else
                {
                    throw new Exception("Account Type is not available");
                }
            }
        }
        public int BIC { get { return bIC; } set { bIC = value; } }
        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
        public int AccountPIN { get { return accountPIN; } set { accountPIN = value; } }

        // accounting constructions to receive the values 
        public BankAccount(string accountCustomerName, string accountType, int bIC, int accountNumber, double balance)
        {
            this.accountCustomerName = accountCustomerName;
            this.accountType = accountType;
            this.bIC = bIC;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }


        public double LodgeMoney(double amount)
        {
            balance += amount;
            return balance;
        }

        public double WithdrawMoney(double inWithdrawMoney)
        {
            if (balance >= inWithdrawMoney)
            {
                balance -= inWithdrawMoney;
            }
            else
            {
                Console.WriteLine("Balance not available for transaction");
            }

            return balance;
        }

        public void CheckBalance()
        {
            Console.WriteLine("Your Balance is {0} ", balance);
        }

        public override string ToString()
        {
            return "Name " + AccountCustomerName + " The Balance is " + balance.ToString() + "Account Number " + AccountNumber;
        }
       

    }
}

using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = " ";
            bool isValid = false;

            BankAccount BankAccount = new BankAccount(); //instance of the class 

            Console.Write("Enter Customer Name ");
            BankAccount.AccountCustomerName = Console.ReadLine();


            do
            {
                try
                {
                  
                    isValid = true;
                    Console.Write("Enter Type Account ");
                    BankAccount.AccountType = Console.ReadLine().ToLower();

                    Console.Write("Enter BIC ");
                    BankAccount.BIC = int.Parse(Console.ReadLine());

                    Console.Write("Enter Account Number ");
                    BankAccount.AccountNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter Balance ");
                    BankAccount.Balance = double.Parse(Console.ReadLine());

                    Console.Write("Enter Account PIN ");
                    BankAccount.AccountPIN = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    isValid = false;
                    Console.WriteLine(ex.Message);
                }
            } while (isValid == false);
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter Trans");
                Console.WriteLine("1.	Lodge money ");
                Console.WriteLine("2.	Withdraw money ");
                Console.WriteLine("3.	Check Balance ");
                Console.WriteLine("4.	Check Balance ");
                Console.WriteLine("5.	Exit ");

                choice = Console.ReadLine();

                Menu(choice, BankAccount);

            } while (choice != "5");

            Console.WriteLine(BankAccount.ToString());

            Console.ReadLine();
        }

        private static void Menu(string choice, BankAccount BankAccount)
        {
            switch (choice)
            {
                case "1":   //Lodge money 
                    BankAccount.Balance = BankAccount.LodgeMoney(20);
                    break;
                case "2": //Withdraw money 
                    BankAccount.Balance = BankAccount.WithdrawMoney(10);
                    break;
                case "3": //Check Balance 
                    BankAccount.CheckBalance();
                    break;
                case "4": //Check Balance 
                          //    BankAccount.ChangePIN(555);
                    break;
                default:
                    Console.WriteLine("Wrong value, please try again");
                    break;
            }

        }


    }

}


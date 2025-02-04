using System;

class BankAccount
{
    //Static variable 
    private static string bankName = "ABC Bank";
    private static int totalAccounts = 0;


    //Readonly variable (immutable)
    public readonly int AccountNumber;
    public string AccountHolderName;
    private double balance;


    //Constructor
    public BankAccount(string AccountHolderName, int AccountNumber, double balance)
    {
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber;
        this.balance = balance;
        totalAccounts++;

    }


    //static method to display all the accounts

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    //Method to display all the details
    public void DisplayAccountDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine("BankName: " + bankName);
            Console.WriteLine("Account Name: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + balance);


        }
        else
        {
            Console.WriteLine("Invalid Account object");
        }


    }
}

    class Bank
    {
        static void Main()
        {
            //Creating bank account objects
            BankAccount ob1 = new BankAccount("Rishabh", 58479, 22000.2);
            BankAccount ob2 = new BankAccount("Ishal", 38772, 22.5);

            ob1.DisplayAccountDetails();
            Console.WriteLine();
            ob2.DisplayAccountDetails();

            //total account account
            BankAccount.GetTotalAccounts();




        }
    }

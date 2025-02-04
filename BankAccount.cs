using System;

// Defining a class BankAccount
public class BankAccount
{
    protected string accountNumber;  // Changed to protected for access in derived class
    protected string accountHolder;
    private decimal balance;

    // Parameterized constructor
    public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    // Defining a method to get the balance of the account
    public decimal GetBalance()
    {
        return balance;
    }

    // Defining a method to deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Defining a method to withdraw money from the account
    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
}

public class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder, decimal initialBalance)
        : base(accountNumber, accountHolder, initialBalance)
    {
    }

    // Method to display account info
    public void DisplayAccountInfo()
    {
        Console.WriteLine(string.Format("Account Number: {0}", accountNumber));
        Console.WriteLine(string.Format("Account Holder: {0}", accountHolder));
    }
}

class Program
{
    static void Main()
    {
        // Create a new SavingsAccount
        SavingsAccount savings = new SavingsAccount("123456789", "Rishabh Kushwah", 1000.00m);
        savings.DisplayAccountInfo();
        Console.WriteLine(string.Format("Initial Balance: {0}", savings.GetBalance()));

        // Deposit money
        savings.Deposit(500.00m);
        Console.WriteLine(string.Format("Balance after deposit: {0}", savings.GetBalance()));

        // Withdraw money
        if (savings.Withdraw(200.00m))
        {
            Console.WriteLine(string.Format("Balance after withdrawal: {0}", savings.GetBalance()));
        }
        else
        {
            Console.WriteLine("Withdrawal failed.");
        }
    }
}

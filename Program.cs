using System;

public class Account
{
    public string AccountNumber { get; }
    public decimal Balance { get; private set; }
    public string AccountType { get; }

    // Default constructor for checking account
    public Account(string accountNumber, decimal balance = 0, string accountType = "Checking")
    {
        AccountNumber = accountNumber;
        Balance = balance;
        AccountType = accountType;
    }

    // Method to depositing money into the account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance is ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount to deposit.");
        }
    }

    // Method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew ${amount}. New balance is ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount to withdraw or insufficient funds.");
        }
    }

    public override string ToString()
    {
        return $"Account Number: {AccountNumber}, Balance: ${Balance}, Type: {AccountType}";
    }

    // Example of usage
    static void Main(string[] args)
    {
        // Creating a checking account
        Account checkingAccount = new Account("123456");
        Console.WriteLine(checkingAccount);

        // Depositing money
        checkingAccount.Deposit(100);
        checkingAccount.Withdraw(50);

        // Creating a savings account
        Account savingsAccount = new Account("789012", accountType: "Savings");
        Console.WriteLine(savingsAccount);

        // Depositing money
        savingsAccount.Deposit(500);
        savingsAccount.Withdraw(200);
    }
}

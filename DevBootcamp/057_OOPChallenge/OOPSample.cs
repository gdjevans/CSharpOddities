using System;

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public double Balance { get; private set; }
    public string OwnerName { get; private set; }

    public BankAccount(string accountNumber, string ownerName)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = 0; // Initial balance is zero
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount:0.00}. New balance: ${Balance:0.00}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn ${amount:0.00}. New balance: ${Balance:0.00}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
        }
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Balance: ${Balance:0.00}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("123456789", "John Doe");
        account.Deposit(1000);
        account.Withdraw(500);
        account.Deposit(200);
        account.DisplayAccountInfo();
    }
}

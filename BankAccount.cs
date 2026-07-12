using System;

class BankAccount
{
    // Private Fields
    private string accountHolder;
    private double balance;

    // Property for Account Holder
    public string AccountHolder
    {
        get
        {
            return accountHolder;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Account Holder Name cannot be empty.");
            }
            else
            {
                accountHolder = value;
            }
        }
    }

    // Property for Balance
    public double Balance
    {
        get
        {
            return balance;
        }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
            }
            else
            {
                balance = value;
            }
        }
    }

    // Method
    public void ShowDetails()
    {
        Console.WriteLine("\n===== ACCOUNT DETAILS =====");
        Console.WriteLine("Account Holder : " + accountHolder);
        Console.WriteLine("Balance        : " + balance);
    }
}
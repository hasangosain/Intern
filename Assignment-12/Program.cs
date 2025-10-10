using System;

/// <summary>
/// Represents a simple bank account with deposit and withdrawal functionality.
/// </summary>
class BankAccount
{
    private string accountNumber;
    private double balance;
    private string ownerName;

    /// <summary>
    /// Gets or sets the account number.
    /// </summary>
    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    /// <summary>
    /// Gets or sets the account owner's name.
    /// </summary>
    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    /// <summary>
    /// Gets or sets the account balance. Prevents setting a negative balance.
    /// </summary>
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value < 0)
            {
                Console.WriteLine("Error: Balance cannot be negative!");
            }
            else
            {
                balance = value;
            }
        }
    }

    /// <summary>
    /// Constructor to initialize the bank account with details.
    /// </summary>
    /// <param name="accountNumber">The unique account number.</param>
    /// <param name="ownerName">The name of the account owner.</param>
    /// <param name="initialBalance">Initial account balance.</param>
    public BankAccount(string accountNumber, string ownerName, double initialBalance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialBalance >= 0 ? initialBalance : 0;
    }

    /// <summary>
    /// Deposits money into the account.
    /// </summary>
    /// <param name="amount">The amount to deposit.</param>
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: ${amount}. New Balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    /// <summary>
    /// Withdraws money from the account if sufficient balance is available.
    /// </summary>
    /// <param name="amount">The amount to withdraw.</param>
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}. Remaining Balance: ${Balance}");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Error: Insufficient balance!");
        }
        else
        {
            Console.WriteLine("Error: Invalid withdrawal amount!");
        }
    }

    /// <summary>
    /// Returns the current account balance.
    /// </summary>
    /// <returns>Current balance.</returns>
    public double GetBalance()
    {
        return Balance;
    }
}

/// <summary>
/// Test program to demonstrate the BankAccount class.
/// </summary>
class Program
{
    static void Main()
    {
        Console.WriteLine("Bank Account Details ");
        BankAccount account1 = new BankAccount("ACC1001", "Hasan Gosain", 1000);

        account1.Deposit(500);
        account1.Withdraw(200);
        Console.WriteLine($"Final Balance: ${account1.GetBalance()}");
    }
}

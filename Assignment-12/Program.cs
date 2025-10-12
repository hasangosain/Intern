using System;

/// <summary>
/// Custom exception thrown when a withdrawal exceeds the available balance.
/// </summary>
public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

/// <summary>
/// Represents a simple bank account with deposit and withdrawal functionality.
/// </summary>
class BankAccount
{
    private string accountNumber;
    private double balance;
    private string ownerName;

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }

    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Balance cannot be negative.");
            }
            balance = value;
        }
    }

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
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        Balance += amount;
        Console.WriteLine($"Deposited: ${amount}. New Balance: ${Balance}");
    }

    /// <summary>
    /// Withdraws money from the account if sufficient balance is available.
    /// </summary>
    /// <param name="amount">The amount to withdraw.</param>
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }

        if (amount > Balance)
        {
            throw new InsufficientFundsException("Insufficient balance for this withdrawal.");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawn: ${amount}. Remaining Balance: ${Balance}");
    }

    public double GetBalance() => Balance;
}

/// <summary>
/// Test program to demonstrate the BankAccount class with exception handling.
/// </summary>
class Program
{
    static void Main()
    {
        try
        {
            BankAccount account1 = new BankAccount("ACC1001", "Hasan Gosain", 1000);

            account1.Deposit(500);
            account1.Withdraw(200);
            account1.Withdraw(2000); // This will trigger InsufficientFundsException

            Console.WriteLine($"Final Balance: ${account1.GetBalance()}");
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Argument Exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}

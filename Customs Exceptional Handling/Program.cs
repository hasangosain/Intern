
// 1: Definition
//Custom Exception Handling is the process of creating user-defined exception classes to handle 
//specific errors in an application that are not adequately addressed by built-in exceptions.
//User creates exception as Per the need of the code.
//Also called User Defined Exception.

//Example:
//Program where user age is less than 18 years (not valid for vote).
//In a banking system, withdrawing more than the available balance can throw an InsufficientFundsException.

// 2: When to Use Custom Exceptions
//Built-in Exceptions Are Too Generic:
//Built -in exceptions like Exception or InvalidOperationException don’t convey enough information.
//Need Meaningful Error Messages:

// 4: Merits
//Makes code self-explanatory and easier to maintain.
//Enables precise and meaningful error handling.
//Improves robustness and fault tolerance.
//Helps in logging domain-specific errors effectively.


// 5: Demerits
//Slightly increases code complexity.
//May overuse exceptions, which can affect performance.
//Requires extra effort to define and maintain multiple custom exceptions.
using System;

// Custom exception class
public class NotValidAge : Exception
{
    public NotValidAge(string message) : base(message)
    {
    }
}

class Amnil
{
    // Method to check age
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new NotValidAge("Age is not valid to vote");
        }
        else
        {
            Console.WriteLine("You are eligible to vote");
        }
    }

    // Main method (entry point)
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            CheckAge(age);
        }
        catch (NotValidAge e)
        {
            Console.WriteLine("Exception caught: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid input format: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred: " + e.Message);
        }
    }
}





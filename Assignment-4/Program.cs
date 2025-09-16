using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine(" Simple Calculator ");

        // Menu for operations
        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Compound Interest");
        Console.Write("Enter your choice (1-5): ");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine(); // blank line for readability

        switch (choice)
        {
            case 1:
                PerformAddition();
                break;

            case 2:
                PerformSubtraction();
                break;

            case 3:
                PerformMultiplication();
                break;

            case 4:
                PerformDivision();
                break;

            case 5:
                PerformCompoundInterest();
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    //  Calculation Methods 

    static void PerformAddition()
    {
        (double num1, double num2) = GetTwoNumbers();
        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
    }

    static void PerformSubtraction()
    {
        (double num1, double num2) = GetTwoNumbers();
        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
    }

    static void PerformMultiplication()
    {
        (double num1, double num2) = GetTwoNumbers();
        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
    }

    static void PerformDivision()
    {
        (double num1, double num2) = GetTwoNumbers();
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed!");
        }
        else
        {
            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
        }
    }

  static void PerformCompoundInterest()
    {
        Console.Write("Enter Principal amount (P): ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Annual Interest Rate (in %): ");
        double ratePercent = double.Parse(Console.ReadLine());
        double rate = ratePercent / 100; // convert % to decimal

        Console.Write("Enter number of times interest is compounded per year (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter time in years (t): ");
        double t = double.Parse(Console.ReadLine());

        // A = P(1 + r/n)^(nt)
        double amount = principal * Math.Pow(1 + rate / n, n * t);

        Console.WriteLine($"\nCompound Interest Amount (A): {amount:F2}");
    }

    //  Helper Method 
    static (double, double) GetTwoNumbers()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        return (num1, num2);
    }
}
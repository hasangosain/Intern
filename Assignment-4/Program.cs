using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Simple Calculator ===");

        // Get two numbers from user
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

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
                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                break;

            case 2:
                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                break;

            case 3:
                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                break;

            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed!");
                }
                else
                {
                    Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                }
                break;

            case 5:
                // Compound Interest Calculation
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
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
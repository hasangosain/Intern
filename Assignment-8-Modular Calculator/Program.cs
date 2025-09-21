using System;

class Calculator
{
    // Addition
    public static double Add(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }

    // Subtraction
    public static double Subtract(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }

    // Multiplication
    public static double Multiply(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    // Division
    public static double Divide(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;
        }
        return firstNumber / secondNumber;
    }
}

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n Modular Calculator ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)
            {
                exit = true;
                Console.WriteLine("Exiting Calculator... Goodbye!");
                continue;
            }

            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Calculator.Add(firstNumber, secondNumber);
                    Console.WriteLine($"Result: {firstNumber} + {secondNumber} = {result}");
                    break;
                case 2:
                    result = Calculator.Subtract(firstNumber, secondNumber);
                    Console.WriteLine($"Result: {firstNumber} - {secondNumber} = {result}");
                    break;
                case 3:
                    result = Calculator.Multiply(firstNumber, secondNumber);
                    Console.WriteLine($"Result: {firstNumber} * {secondNumber} = {result}");
                    break;
                case 4:
                    result = Calculator.Divide(firstNumber, secondNumber);
                    if (!double.IsNaN(result))
                        Console.WriteLine($"Result: {firstNumber} / {secondNumber} = {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
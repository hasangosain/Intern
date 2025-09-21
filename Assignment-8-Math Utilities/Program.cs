using System;

class MathUtilities
{
    // Calculate area of circle
    public static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Calculate area of rectangle
    public static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    // Calculate area of triangle
    public static double CalculateArea(double baseLength, double height, bool isTriangle)
    {
        return 0.5 * baseLength * height;
    }

    // Check if a number is prime
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // Calculate factorial
    public static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("Factorial not defined for negative numbers");
        if (n == 0 || n == 1) return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n Math Utilities Menu ");
            Console.WriteLine("1. Area Calculator");
            Console.WriteLine("2. Prime Number Check");
            Console.WriteLine("3. Factorial");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nChoose a Shape:");
                    Console.WriteLine("1. Circle");
                    Console.WriteLine("2. Rectangle");
                    Console.WriteLine("3. Triangle");
                    Console.Write("Enter your choice: ");
                    int shapeChoice = Convert.ToInt32(Console.ReadLine());

                    switch (shapeChoice)
                    {
                        case 1: // Circle
                            Console.Write("Enter radius of circle: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Area of Circle: {MathUtilities.CalculateArea(radius)}");
                            break;

                        case 2: // Rectangle
                            Console.Write("Enter length of rectangle: ");
                            double length = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter width of rectangle: ");
                            double width = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Area of Rectangle: {MathUtilities.CalculateArea(length, width)}");
                            break;

                        case 3: // Triangle
                            Console.Write("Enter base of triangle: ");
                            double baseLength = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter height of triangle: ");
                            double height = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Area of Triangle: {MathUtilities.CalculateArea(baseLength, height, true)}");
                            break;

                        default:
                            Console.WriteLine("Invalid shape choice!");
                            break;
                    }
                    break;

                case 2: // Prime check
                    Console.Write("Enter a number to check if it is prime: ");
                    int primeNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{primeNum} is {(MathUtilities.IsPrime(primeNum) ? "Prime" : "Not Prime")}");
                    break;

                case 3: // Factorial
                    Console.Write("Enter a number to calculate factorial: ");
                    int factNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Factorial of {factNum} = {MathUtilities.Factorial(factNum)}");
                    break;

                case 4: // Exit
                    exit = true;
                    Console.WriteLine("Exiting program... Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
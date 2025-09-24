 ///Syntax
/// <summary>
/// A short description of what the method does.
/// </summary>
/// <param name="parameterName">Explains what this parameter is for.</param>
/// <returns>Describes what the method returns.</returns>


using System;

class Calculator
{
    /// <summary>
    /// Adds two integers and returns their sum.
    /// </summary>
    /// <param name="a">The first integer value.</param>
    /// <param name="b">The second integer value.</param>
    /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
    public static int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Divides one number by another.
    /// </summary>
    /// <param name="numerator">The number to be divided.</param>
    /// <param name="denominator">The number to divide by. Must not be zero.</param>
    /// <returns>The result of division as a double.</returns>
    /// <exception cref="DivideByZeroException">
    /// Thrown when <paramref name="denominator"/> is zero.
    /// </exception>
    public static double Divide(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");

        return (double)numerator / denominator;
    }
}

class Program
{
    static void Main()
    {
        int sum = Calculator.Add(10, 20);
        double result = Calculator.Divide(10, 2);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Division: {result}");
    }
}

// Explanation of Tags Used

//<summary> → Brief explanation of what the method does.

//<param> → Description of each parameter.

//<returns> → What the method returns.

//<exception> → Lists possible exceptions the method might throw.

//<paramref> → Refers to a parameter by name inside your comments.

// How It Looks in Visual Studio

//When you type Calculator.Add( in Visual Studio, IntelliSense will show:

//Adds two integers and returns their sum.
//a: The first integer value.
//b: The second integer value.
//Returns: The sum of a and b.
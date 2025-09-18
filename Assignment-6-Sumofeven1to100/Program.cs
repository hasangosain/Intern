using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sum of Even Numbers Between 1 and 100: ");

        int sumEvenNum = CalculateEvenSum(1, 100);

        Console.WriteLine($"The sum of all even numbers between 1 and 100 is: {sumEvenNum}");
    }

    // Method to calculate sum of even numbers in a given range
    static int CalculateEvenSum(int firstNum, int lastNum)
    {
        int sumEvenNum = 0;

        for (int i = firstNum; i <= lastNum; i++)
        {
            if (i % 2 == 0)  // check if number is even
            {
                sumEvenNum += i;
            }
        }

        return sumEvenNum;
    }
}
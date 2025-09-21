using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pattern Printing Program");
        Console.WriteLine("1. Print Triangle (Pyramid)");
        Console.WriteLine("2. Print Diamond");
        Console.WriteLine("3. Exit");

        while (true)
        {
            Console.Write("\nEnter your choice (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter size of pattern: ");
            int patternSize = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintTriangle(patternSize);
                    break;
                case 2:
                    PrintDiamond(patternSize);
                    break;
                case 3:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }

    // Centered Triangle (Pyramid)
    static void PrintTriangle(int sizeOfTriangle)
    {
        Console.WriteLine("\nTriangle:");
        for (int i = 1; i <= sizeOfTriangle; i++)
        {
            // Print spaces
            for (int space = 1; space <= sizeOfTriangle - i; space++)
                Console.Write(" ");
            // Print stars
            for (int star = 1; star <= (2 * i - 1); star++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    // Diamond
    static void PrintDiamond(int sizeOfDiamond)
    {
        Console.WriteLine("\nDiamond:");
        // Upper half
        for (int i = 1; i <= sizeOfDiamond; i++)
        {
            for (int space = 1; space <= sizeOfDiamond - i; space++)
                Console.Write(" ");
            for (int star = 1; star <= (2 * i - 1); star++)
                Console.Write("*");
            Console.WriteLine();
        }
        // Lower half
        for (int i = sizeOfDiamond - 1; i >= 1; i--)
        {
            for (int space = 1; space <= sizeOfDiamond - i; space++)
                Console.Write(" ");
            for (int star = 1; star <= (2 * i - 1); star++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}

using System;

class MultiplicationTables
{
    static void Main()
    {
        Console.WriteLine("Multiplication Tables from 1 to 10: \n");

        for (int i = 1; i <= 10; i++)  // Loop for tables 1 to 10
        {
            Console.WriteLine($" Table of {i}: ");

            for (int j = 1; j <= 10; j++)  // Loop for each multiplication row
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }

            Console.WriteLine(); // Blank line between tables
        }
    }
}
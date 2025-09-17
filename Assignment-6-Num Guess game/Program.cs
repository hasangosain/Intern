using System;

class NumberGuessingGame
{
    static void Main()
    {
        Console.WriteLine(" Welcome to the Number Guessing Game!");
        Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!\n");

        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Random number between 1–100
        int attempts = 0;
        int guess = 0;

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine(" Too low! Try again.\n");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine(" Too high! Try again.\n");
                }
                else
                {
                    Console.WriteLine($"\n Correct! The number was {secretNumber}.");
                    Console.WriteLine($" You guessed it in {attempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine(" Invalid input. Please enter a number.");
            }
        }
    }
}
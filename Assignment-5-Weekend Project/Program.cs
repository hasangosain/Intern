//Rock,Paper,Scissors Game
using System;

class Program
{
    static void Main()
    {
        RockPaperScissorsGame();
    }

    static void RockPaperScissorsGame()
    {
        // choices between player and computer
        string[] choices = { "rock", "paper", "scissors" };

        Random random = new Random();

        bool playAgain = true;

        Console.WriteLine("Welcome to Rock, Paper, Scissors Game!");
        Console.WriteLine("Press any key to start...");
        Console.ReadLine();

        while (playAgain == true)
        {
            // Player input
            Console.Write("Enter Rock, Paper, or Scissors: ");
            string playerChoice = Console.ReadLine();
            playerChoice = playerChoice.ToLower();

            if (Array.IndexOf(choices, playerChoice) == -1)
            {
                Console.WriteLine("Invalid choice, try again.");
                continue;
            }

            // Computer choice
            string computerChoice = choices[random.Next(0, choices.Length)];
            Console.WriteLine($"Computer chose: {computerChoice}");

            // Decide winner
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("Game is tied!");
            }
            else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                     (playerChoice == "scissors" && computerChoice == "paper") ||
                     (playerChoice == "paper" && computerChoice == "rock"))
            {
                Console.WriteLine("Congratulations You won!");
            }
            else
            {
                Console.WriteLine("Sorry you lost.The Computer won!");
            }

            // Play again?
            Console.Write("Do you want to play this game again? (y/n) : ");
            playAgain = Console.ReadLine().ToLower() == "y";
        }

        Console.WriteLine("Thanks for playing!");

    }
}
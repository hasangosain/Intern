using System;

class RestaurantMenu
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            DisplayMenu();
            int choice = GetChoice();
            keepRunning = ProcessChoice(choice);
        }
    }

    // Method to display menu
    static void DisplayMenu()
    {
        Console.WriteLine("\n=== Welcome to Hasan's Restaurant ===");
        Console.WriteLine("1. Pizza - Rs. 300");
        Console.WriteLine("2. Burger - Rs. 150");
        Console.WriteLine("3. Momo - Rs. 100");
        Console.WriteLine("4. Chowmein - Rs. 120");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice (1-5): ");
    }

    // Method to get user choice
    static int GetChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
        {
            Console.Write("Invalid input. Please enter a number between 1 and 5: ");
        }
        return choice;
    }

    // Method to process choice with switch statement
    static bool ProcessChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine(" You ordered Pizza. Delicious choice!");
                break;
            case 2:
                Console.WriteLine(" You ordered Burger. Yummy!");
                break;
            case 3:
                Console.WriteLine(" You ordered Momo. Perfect snack!");
                break;
            case 4:
                Console.WriteLine(" You ordered Chowmein. Spicy and tasty!");
                break;
            case 5:
                Console.WriteLine(" Thank you for visiting Hasan's Restaurant!");
                return false; // Exit loop
        }
        return true; // Continue loop
    }
}
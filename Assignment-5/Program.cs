using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine(" Grade Calculator ");

        bool exit = false;
        while (!exit)
        {
            // Show Menu
            ShowMenu();
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateGrade();
                    break;

                case 2:
                    Console.WriteLine("Exiting program... Goodbye!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select again.");
                    break;
            }

            Console.WriteLine(); // blank line for readability
        }
    }

    // Method: Show the menu
    static void ShowMenu()
    {
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Calculate Grade Of Student");
        Console.WriteLine("2. Exit");
    }

    // Method: Calculate grade from numeric score
    static void CalculateGrade()
    {
        Console.Write("Enter the numeric score (0 - 100): ");
        int gradeScore = int.Parse(Console.ReadLine());

        string grade = GetLetterGrade(gradeScore);

        Console.WriteLine($"Score: {gradeScore}, Grade: {grade}");
    }

    // Method: Convert numeric score → Letter grade
    static string GetLetterGrade(int gradeScore)
    {
        if (gradeScore >= 90 && gradeScore <= 100) return " Grade = A+";
        else if (gradeScore >= 80 && gradeScore <= 89) return " Grade = A ";
        else if (gradeScore >= 70 && gradeScore <= 79) return " Grade = B ";
        else if (gradeScore >= 60 && gradeScore <= 69) return " Grade = C ";
        else if (gradeScore >= 50 && gradeScore <= 59) return " Grade = D ";
        else return "F";
    }
}

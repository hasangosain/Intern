class StudentGradeManagementSystem
{
    // Maximum number of students (array size)
    static int maxStudents = 100;

    // Array to store student names
    static string[] studentNames = new string[maxStudents];

    // Array to store student grades (default -1 means no grade yet)
    static double[] studentGrades = new double[maxStudents];

    // Counter for number of students
    static int studentCount = 0;

    /// <summary>
    /// Main entry point of the program. 
    /// Displays menu and handles user input.
    /// </summary>
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n Student Grade Management System ");
            Console.WriteLine("1) Add Student and Grade");
            Console.WriteLine("2) Display Report");
            Console.WriteLine("3) Calculate Class Average");
            Console.WriteLine("4) Exit");
            Console.Write("Choose an option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudentAndGrade();
                    break;

                case "2":
                    DisplayReport();
                    break;

                case "3":
                    CalculateAverage();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting program... Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    /// <summary>
    /// Adds a new student and assigns a grade at the same time.
    /// Validates input for stuName and grade.
    /// </summary>
    static void AddStudentAndGrade()
    {
        if (studentCount >= maxStudents)
        {
            Console.WriteLine("Cannot add more students. Maximum limit reached.");
            return;
        }

        // Get student name
        Console.Write("Enter student name: ");
        string stuName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(stuName))
        {
            Console.WriteLine("Invalid name. Try again.");
            return;
        }

        // Get student grade
        Console.Write("Enter grade (0 - 100): ");
        if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 100)
        {
            studentNames[studentCount] = stuName;
            studentGrades[studentCount] = grade;
            studentCount++;
            Console.WriteLine($"Student '{stuName}' with grade {grade} ({GetLetterGrade(grade)}) added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid grade. Must be a number between 0 and 100.");
        }
    }

    /// <summary>
    /// Displays all students with their numeric and letter grades.
    /// </summary>
    static void DisplayReport()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students to display.");
            return;
        }

        Console.WriteLine("\n Student Report ");
        for (int i = 0; i < studentCount; i++)
        {
            double grade = studentGrades[i];
            Console.WriteLine($"{studentNames[i]} - Grade: {grade} ({GetLetterGrade(grade)})");
        }
    }

    /// <summary>
    /// Calculates and displays the class average grade with letter equivalent.
    /// </summary>
    static void CalculateAverage()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students available to calculate average.");
            return;
        }

        double total = 0;
        for (int i = 0; i < studentCount; i++)
        {
            total += studentGrades[i];
        }

        double average = total / studentCount;
        Console.WriteLine($"\nClass Average: {average:F2} ({GetLetterGrade(average)})");
    }

    /// <summary>
    /// Converts numeric grade into a letter grade (A, B, C, D, F).
    /// </summary>
    /// <param name="grade">Numeric grade between 0 and 100.</param>
    /// <returns>Letter grade as string.</returns>
    static string GetLetterGrade(double grade)
    {
        if (grade >= 90)
            return "A";
        else if (grade >= 80)
            return "B";
        else if (grade >= 70)
            return "C";
        else if (grade >= 60)
            return "D";
        else
            return "F";
    }
}

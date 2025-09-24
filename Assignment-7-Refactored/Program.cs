using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

// String Utilities Library
static class StringUtilities
{
    /// <summary>
    /// Counts the number of words in a string (separated by spaces, tabs, or newlines).
    /// </summary>
    public static int CountWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return 0;

        return input.Split(
            new char[] { ' ', '\t', '\n' },
            StringSplitOptions.RemoveEmptyEntries
        ).Length;
    }

    /// <summary>
    /// Reverses a given string.
    /// </summary>
    public static string ReverseString(string input)
    {
        if (input == null) return string.Empty;
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    /// <summary>
    /// Checks if a string is a palindrome (ignores spaces and case).
    /// </summary>
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;

        string cleaned = new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();
        return cleaned == ReverseString(cleaned).ToLower();
    }

    /// <summary>
    /// Removes all spaces from a string.
    /// </summary>
    public static string RemoveSpaces(string input)
    {
        if (input == null) return string.Empty;
        return input.Replace(" ", "");
    }
}

class Program
{
    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEnter your choice from 1-5");
            Console.WriteLine("1) Student Grades");
            Console.WriteLine("2) Bubble Sort Implementation");
            Console.WriteLine("3) Weekly Temperature Tracker");
            Console.WriteLine("4) String Utilities");
            Console.WriteLine("5) Exit");
            Console.Write("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            switch (option)
            {
                case 1: StudentGradesMenu(); break;
                case 2: BubbleSortImplementation(); break;
                case 3: WeeklyTemperatureTracker(); break;
                case 4: StringUtilitiesMenu(); break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    //  STUDENT GRADES 
    static void StudentGradesMenu()
    {
        List<Student> students = new List<Student>();
        bool active = true;

        while (active)
        {
            Console.WriteLine("\n Student Grades Menu ");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Show Statistics (Highest, Lowest, Average)");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter grade (0-100): ");
                    int grade;
                    while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
                    {
                        Console.Write("Invalid grade! Enter between 0 and 100: ");
                    }

                    students.Add(new Student { Name = name, Grade = grade });
                    Console.WriteLine("✅ Student added successfully.");
                    break;

                case "2":
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No students recorded yet.");
                        continue;
                    }

                    Console.WriteLine("\n Student List ");
                    foreach (var s in students)
                    {
                        Console.WriteLine($"Name: {s.Name}, Grade: {s.Grade}");
                    }
                    break;

                case "3":
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No records yet.");
                        continue;
                    }

                    int highest = students.Max(s => s.Grade);
                    int lowest = students.Min(s => s.Grade);
                    double avg = students.Average(s => s.Grade);

                    Console.WriteLine($"Highest Grade: {highest}");
                    Console.WriteLine($"Lowest Grade: {lowest}");
                    Console.WriteLine($"Average Grade: {avg:F2}");
                    break;

                case "4":
                    active = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // BUBBLE SORT 
    static void BubbleSortImplementation()
    {
        Console.WriteLine("\nBubble Sort Implementation");
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        int[] arr;

        try
        {
            arr = input.Split(' ').Select(int.Parse).ToArray();
        }
        catch
        {
            Console.WriteLine("Invalid input. Returning to main menu.");
            return;
        }

        Console.WriteLine("Original array: " + string.Join(", ", arr));
        BubbleSort(arr);
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // WEEKLY TEMPERATURE TRACKER 
    static void WeeklyTemperatureTracker()
    {
        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        int[] temps = new int[7];

        Console.WriteLine("\n Weekly Temperature Tracker ");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Enter temperature for {days[i]}: ");
            while (!int.TryParse(Console.ReadLine(), out temps[i]))
            {
                Console.Write("Invalid input. Enter an integer: ");
            }
        }

        Console.WriteLine("\nTemperatures recorded:");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"{days[i]}: {temps[i]}°");
        }

        int highest = temps.Max();
        int lowest = temps.Min();
        double avg = temps.Average();

        string highDay = days[Array.IndexOf(temps, highest)];
        string lowDay = days[Array.IndexOf(temps, lowest)];

        Console.WriteLine($"\nHighest Temp: {highest}° on {highDay}");
        Console.WriteLine($"Lowest Temp: {lowest}° on {lowDay}");
        Console.WriteLine($"Average Temp: {avg:F2}°");
    }

    //  STRING UTILITIES MENU 
 
    static void StringUtilitiesMenu()
    {
        Console.WriteLine("\n String Utilities ");
        Console.Write("Enter your string: ");
        string input = Console.ReadLine();

        // Show all outputs at once
        Console.WriteLine($"\nOriginal String: {input}");
        Console.WriteLine($"Word Count: {StringUtilities.CountWords(input)}");
        Console.WriteLine($"Reversed String: {StringUtilities.ReverseString(input)}");
        Console.WriteLine($"Is Palindrome? {(StringUtilities.IsPalindrome(input) ? "Yes" : "No")}");
        Console.WriteLine($"Without Spaces: {StringUtilities.RemoveSpaces(input)}");
    }

}

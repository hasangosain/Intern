using System;
using System.IO;

class TextFileProcessor
{
    static void Main()
    {
        Console.WriteLine(" Text File Processor ");

        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filePath))
        {
            Console.WriteLine("Error: File path cannot be empty!");
            return;
        }

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: File not found!");
            return;
        }

        bool exit = false;
        while (!exit)
        {
            try
            {
                Console.WriteLine("\n Menu ");
                Console.WriteLine("1. Count Lines, Words, and Characters");
                Console.WriteLine("2. Create Backup Copy");
                Console.WriteLine("3. Search for Specific Text");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CountFileDetails(filePath);
                        break;

                    case "2":
                        CreateBackup(filePath);
                        break;

                    case "3":
                        SearchText(filePath);
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                        break;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: The file was not found.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Access denied. Check file permissions.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error occurred: {ex.Message}");
            }
        }
    }

    //  Counts lines, words, and characters 
    static void CountFileDetails(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            int lineCount = lines.Length;
            int wordCount = 0;
            int charCount = 0;

            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
                charCount += line.Length;
            }

            Console.WriteLine("\n File Details ");
            Console.WriteLine($"Total Lines: {lineCount}");
            Console.WriteLine($"Total Words: {wordCount}");
            Console.WriteLine($"Total Characters: {charCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while reading file: {ex.Message}");
        }
    }

    //  Creates backup copy 
    static void CreateBackup(string filePath)
    {
        try
        {
            string directory = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);

            string backupPath = Path.Combine(directory, fileName + "_backup" + extension);
            File.Copy(filePath, backupPath, true);

            Console.WriteLine($"\nBackup created successfully at: {backupPath}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File copy error: {ex.Message}");
        }
    }

    //  Searches for specific text in file 
    static void SearchText(string filePath)
    {
        try
        {
            Console.Write("Enter text to search: ");
            string searchText = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                Console.WriteLine("Search text cannot be empty.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            Console.WriteLine("\n Search Results ");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Line {i + 1}: {lines[i]}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No matches found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while searching text: {ex.Message}");
        }
    }
}

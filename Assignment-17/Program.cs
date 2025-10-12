using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        Console.WriteLine("Enter the file path to read:");
        string filePath = Console.ReadLine();

        try
        {
            // Attempt to read all lines from the file
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("\n File Contents ");

            foreach (string line in lines)
            {
                try
                {
                    // Try converting line into integer (for FormatException demonstration)
                    int number = int.Parse(line);
                    Console.WriteLine($"Number found: {number}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Invalid data format: '{line}' (not a valid number)");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The specified file was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O Error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nFile reading process completed.");
        }
    }
}

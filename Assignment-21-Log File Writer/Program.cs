using System;
using System.IO;

class LogFileWriter
{
    private string logFilePath;

    // Constructor to set log file path
    public LogFileWriter(string filePath)
    {
        logFilePath = filePath;

        // Create log file if it doesn't exist
        if (!File.Exists(logFilePath))
        {
            File.WriteAllText(logFilePath, " Application Log File Created \n");
        }
    }

    // Method to write a log entry
    public void WriteLog(string message, string level = "INFO")
    {
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {message}";
        File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        Console.WriteLine("✅ Log entry written successfully.");
    }

    // Method to display all logs
    public void DisplayLogs()
    {
        Console.WriteLine("\n Application Log Contents ");
        string logs = File.ReadAllText(logFilePath);
        Console.WriteLine(logs);
    }
}

class Program
{
    static void Main()
    {
        string logFile = "application.log";
        LogFileWriter logger = new LogFileWriter(logFile);

        int choice;
        do
        {
            Console.WriteLine("\n LOG FILE WRITER MENU ");
            Console.WriteLine("1. Write Info Log");
            Console.WriteLine("2. Write Error Log");
            Console.WriteLine("3. View Logs");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice)) choice = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter info message: ");
                    string infoMsg = Console.ReadLine();
                    logger.WriteLog(infoMsg, "INFO");
                    break;

                case 2:
                    Console.Write("Enter error message: ");
                    string errorMsg = Console.ReadLine();
                    logger.WriteLog(errorMsg, "ERROR");
                    break;

                case 3:
                    logger.DisplayLogs();
                    break;

                case 4:
                    Console.WriteLine("Exiting Log Writer...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }

        } while (choice != 4);
    }
}

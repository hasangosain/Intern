using System;

class Program
{
    static void Main()
    {
        // Example variables
        int age = 25;
        float height = 5.9f;
        double weight = 70.5;
        char grade = 'A';
        bool isStudent = true;
        string name = "Hasan Gosain";
        decimal salary = 50000.75m;
        byte level = 1;

        // Display variables
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Is Student: " + isStudent);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Level: " + level);

        // Calculate age in days
        AgeCalculator calculator = new AgeCalculator();
        int ageInDays = calculator.CalculateAgeInDays(new DateTime(1998, 8, 21));
        Console.WriteLine($"You are {ageInDays} days old.");
    }
}

// AgeCalculator class
class AgeCalculator
{
    // Non-static method
    public int CalculateAgeInDays(DateTime birthDate)
    {
        DateTime today = DateTime.Now;
        TimeSpan age = today - birthDate;
        return age.Days;
    }
}

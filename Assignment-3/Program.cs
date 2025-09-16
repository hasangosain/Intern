/*assignment 3: 
• build a "personal information collector" program 
• ask user for name, age, city, and favorite hobby 
• display a formatted summary using string interpolation
 • bonus: calculate birth year from age input*/

using System;

class PersonalInfoCollector
{
    static void Main()
    {
        // Ask for user details
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your city: ");
        string city = Console.ReadLine();

        Console.Write("Enter your favorite hobby: ");
        string hobby = Console.ReadLine();

        // Bonus: calculate birth year
        int currentYear = DateTime.Now.Year;
        int birthYear = currentYear - age;

        // Display formatted summary
        Console.WriteLine("\n--- Personal Information Summary ---");
        Console.WriteLine($"Name       : {name}");
        Console.WriteLine($"Age        : {age}");
        Console.WriteLine($"City       : {city}");
        Console.WriteLine($"Hobby      : {hobby}");
        Console.WriteLine($"Birth Year : {birthYear}");
    }
}

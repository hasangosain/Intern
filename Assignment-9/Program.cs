using System;

public static class StringUtilities
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        Console.WriteLine($"\nOriginal String: {input}");
        Console.WriteLine($"Word Count: {StringUtilities.CountWords(input)}");
        Console.WriteLine($"Reversed: {StringUtilities.ReverseString(input)}");
        Console.WriteLine($"Is Palindrome? {StringUtilities.IsPalindrome(input)}");
        Console.WriteLine($"Without Spaces: {StringUtilities.RemoveSpaces(input)}");
    }

    // CountWords method
    public static int CountWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        string[] words = input.Split(
            new char[] { ' ', '\t', '\n' },
            StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }

    // ReverseString method
    public static string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // IsPalindrome method
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string cleaned = RemoveSpaces(input).ToLower();
        string reversed = ReverseString(cleaned);

        return cleaned == reversed;
    }

    // RemoveSpaces method
    public static string RemoveSpaces(string input)
    {
        return input.Replace(" ", "");
    }
}

    

using System;
using System.Collections.Generic;

class WordFrequencyCounter
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine().ToLower(); // convert to lowercase for uniform counting

        // Split sentence into words (ignore extra spaces)
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Dictionary to store word frequencies
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;     // if word already exists, increment count
            else
                wordCount[word] = 1;   // if word appears first time, set count to 1
        }

        // Display word frequency result
        Console.WriteLine("\n Word Frequency Count ");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}

// 🔹 String Information & Comparison
// Length → Returns the number of characters.
string text = "Hello";
Console.WriteLine(text.Length); // 5

// Equals() → Compares two strings.
Console.WriteLine("Hello".Equals("hello")); // False

// Compare() / CompareTo() → Compares strings (case-sensitive/insensitive).
Console.WriteLine("apple".CompareTo("banana")); // -1


// 🔹 Case Conversion
// ToUpper() → Converts to uppercase.
Console.WriteLine("hello".ToUpper()); // HELLO

// ToLower() → Converts to lowercase.
Console.WriteLine("HELLO".ToLower()); // hello


// 🔹 Searching
// Contains() → Checks if a string contains another string.
Console.WriteLine("Hello World".Contains("World")); // True

// StartsWith() / EndsWith() → Checks beginning or end of string.
Console.WriteLine("Hello".StartsWith("He")); // True
Console.WriteLine("Hello".EndsWith("lo"));   // True

// IndexOf() → Finds the index of first occurrence.
Console.WriteLine("Hello".IndexOf("l")); // 2

// LastIndexOf() → Finds last occurrence.
Console.WriteLine("Hello".LastIndexOf("l")); // 3


// 🔹 Manipulation
// Substring(startIndex, length) → Extracts part of a string.
Console.WriteLine("Hello World".Substring(0, 5)); // Hello

// Replace(old, new) → Replaces text.
Console.WriteLine("Hello".Replace("l", "x")); // Hexxo

// Insert(index, value) → Inserts text at index.
Console.WriteLine("Hello".Insert(5, " World")); // Hello World

// Remove(startIndex, length) → Removes characters.
Console.WriteLine("Hello".Remove(2, 2)); // Heo


// 🔹 Trimming
// Trim() → Removes whitespace from both ends.
// TrimStart() → Removes from start.
// TrimEnd() → Removes from end.
Console.WriteLine("   Hello   ".Trim()); // "Hello"


// 🔹 Splitting & Joining
// Split(separator) → Splits string into an array.
string[] words = "apple,banana,grape".Split(',');

// Join(separator, array) → Joins array into a string.
string result = string.Join("-", words); // apple-banana-grape


// 🔹 Other Useful
// IsNullOrEmpty() → Checks if string is null or empty.
Console.WriteLine(string.IsNullOrEmpty("")); // True

// IsNullOrWhiteSpace() → Checks null, empty, or spaces.
Console.WriteLine(string.IsNullOrWhiteSpace("   ")); // True
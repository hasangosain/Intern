using System;

/// <summary>
/// Represents a book in a library system.
/// </summary>
class Book
{
    /// <summary>
    /// Gets or sets the title of the book.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the author of the book.
    /// </summary>
    public string Author { get; set; }

    /// <summary>
    /// Gets or sets the year of publication.
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets the genre of the book.
    /// </summary>
    public string Genre { get; set; }

    // Methods

    /// <summary>
    /// Marks the book as borrowed.
    /// </summary>
    public void Borrow()
    {
        Console.WriteLine($"\"{Title}\" by {Author} has been borrowed.");
    }

    /// <summary>
    /// Marks the book as returned and optionally shows how many days it was borrowed.
    /// </summary>
    /// <param name="daysBorrowed">Number of days the book was borrowed.</param>
    public void Return(int daysBorrowed)
    {
        Console.WriteLine($"\"{Title}\" by {Author} has been returned after {daysBorrowed} days.");
    }

    /// <summary>
    /// Displays detailed information about the book.
    /// </summary>
    public void GetInfo()
    {
        Console.WriteLine($"Book Info: \"{Title}\", Author: {Author}, Year: {Year}, Genre: {Genre}");
    }

    /// <summary>
    /// Marks the book as reserved.
    /// </summary>
    public void Reserve()
    {
        Console.WriteLine($"\"{Title}\" by {Author} has been reserved.");
    }
}

/// <summary>
/// Main program to test the Book class functionality.
/// </summary>
class Program
{
    static void Main()
    {
        Console.WriteLine("NEPALI LIBRARY BOOK DETAILS \n");

        // Create Nepali book objects with English titles
        Book book1 = new Book { Title = "Munal", Author = "Pushkar", Year = 2018, Genre = "Story" };
        Book book2 = new Book { Title = "Shirishko Phool", Author = "Sudarshan", Year = 2015, Genre = "Novel" };
        Book book3 = new Book { Title = "History of Nepal", Author = "Dhruv", Year = 2020, Genre = "History" };

        // Test functionality
        book1.GetInfo();
        book1.Borrow();
        book1.Return(14);
        book1.Reserve();

        Console.WriteLine();

        book2.GetInfo();
        book2.Borrow();
        book2.Return(7);

        Console.WriteLine();

        book3.GetInfo();
        book3.Reserve();
    }
}

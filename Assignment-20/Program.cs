using System;
using System.Collections.Generic;
using System.Linq;

// Interface for borrowable behavior
interface IBorrowable
{
    void BorrowBook(Book book, Member member);
    void ReturnBook(Book book, Member member);
}

// Book class
class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; } = true;

    public Book(int id, string title, string author)
    {
        BookId = id;
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"{BookId}. {Title} by {Author} (Available: {IsAvailable})";
    }
}

// Abstract base class
abstract class Member
{
    public int MemberId { get; set; }
    public string Name { get; set; }

    protected Member(int id, string name)
    {
        MemberId = id;
        Name = name;
    }

    public abstract void DisplayInfo(); // Polymorphism
}

// Derived classes showing inheritance
class StudentMember : Member
{
    public StudentMember(int id, string name) : base(id, name) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[Student Member] ID: {MemberId}, Name: {Name}");
    }
}

class TeacherMember : Member
{
    public TeacherMember(int id, string name) : base(id, name) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[Teacher Member] ID: {MemberId}, Name: {Name}");
    }
}

// Transaction class
class Transaction
{
    public int TransactionId { get; set; }
    public Member Member { get; set; }
    public Book Book { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; } // Borrow or Return

    public Transaction(int id, Member member, Book book, string type)
    {
        TransactionId = id;
        Member = member;
        Book = book;
        Type = type;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"[{Type}] {Book.Title} by {Member.Name} on {Date}";
    }
}

// Library class implementing IBorrowable
class Library : IBorrowable
{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();
    private List<Transaction> transactions = new List<Transaction>();
    private int transactionCounter = 1;

    // Add a new book
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book added: {book.Title}");
    }

    // Remove a book by ID
    public void RemoveBook(int bookId)
    {
        Book book = books.FirstOrDefault(b => b.BookId == bookId);
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine($"Book removed: {book.Title}");
        }
        else
        {
            Console.WriteLine("Error: Book not found.");
        }
    }

    // Register a new member
    public void RegisterMember(Member member)
    {
        members.Add(member);
        Console.WriteLine($"Member registered: {member.Name}");
    }

    // Borrow a book
    public void BorrowBook(Book book, Member member)
    {
        try
        {
            if (!book.IsAvailable)
                throw new InvalidOperationException("Book is already borrowed by another member.");

            book.IsAvailable = false;
            transactions.Add(new Transaction(transactionCounter++, member, book, "Borrow"));
            Console.WriteLine($"{member.Name} borrowed \"{book.Title}\"");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Return a book
    public void ReturnBook(Book book, Member member)
    {
        try
        {
            if (book.IsAvailable)
                throw new InvalidOperationException("This book was not borrowed.");

            book.IsAvailable = true;
            transactions.Add(new Transaction(transactionCounter++, member, book, "Return"));
            Console.WriteLine($"{member.Name} returned \"{book.Title}\"");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Display all books
    public void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        foreach (var b in books)
            Console.WriteLine(b);
    }

    // Display all transactions
    public void DisplayTransactions()
    {
        Console.WriteLine("\nTransaction Records:");
        foreach (var t in transactions)
            Console.WriteLine(t);
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Library library = new Library();

        // Create books (Nepali context)
        Book b1 = new Book(1, "Seto Bagh", "Diamond Shumsher Rana");
        Book b2 = new Book(2, "Muna Madan", "Laxmi Prasad Devkota");
        Book b3 = new Book(3, "Palpasa Café", "Narayan Wagle");

        // Add books
        library.AddBook(b1);
        library.AddBook(b2);
        library.AddBook(b3);

        // Register members
        Member m1 = new StudentMember(201, "Sujit Shrestha");
        Member m2 = new TeacherMember(202, "Ramesh Adhikari");

        library.RegisterMember(m1);
        library.RegisterMember(m2);

        // Display all books
        library.DisplayBooks();

        // Borrow and return operations
        library.BorrowBook(b1, m1);
        library.BorrowBook(b2, m2);
        library.ReturnBook(b1, m1);

        // Display updated books and transactions
        library.DisplayBooks();
        library.DisplayTransactions();
    }
}

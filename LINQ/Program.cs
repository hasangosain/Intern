// What is LINQ ?

//LINQ(Language Integrated Query) stands for Language Integrated Query.

//It allows you to query(filter, sort, group, or select) data from different data sources directly within C# code in a simple, readable, and consistent way.

//You can use LINQ with:

//Arrays

//Lists

//Databases(via Entity Framework)

//XML files

//Collections, etc.

// Why LINQ is used

//Without LINQ, you would write long loops and conditions to find or filter data.
//With LINQ, you can write short and expressive code.

//👉 LINQ brings SQL - like querying directly into C#.

//🧠 Syntax of LINQ

//There are two ways to write LINQ:

//Query syntax(like SQL)

//Method syntax(using lambda expressions)

//⚙️ Example 1: Using LINQ on a List (Simple and Clear)
//using System;
//using System.Collections.Generic;
//using System.Linq;  // Important for LINQ

//class Program
//{
//    static void Main()
//    {
//        // A list of numbers
//        List<int> numbers = new List<int> { 1, 4, 7, 10, 13, 16, 19 };

//        // --- Query Syntax ---
//        var evenNumbers = from num in numbers
//                          where num % 2 == 0
//                          select num;

//        // --- Method Syntax ---
//        var oddNumbers = numbers.Where(num => num % 2 != 0);

//        Console.WriteLine("Even numbers:");
//        foreach (var n in evenNumbers)
//            Console.WriteLine(n);

//        Console.WriteLine("\nOdd numbers:");
//        foreach (var n in oddNumbers)
//            Console.WriteLine(n);
//    }
//}

//🧾 Output:
//Even numbers:
//4
//10
//16

//Odd numbers:
//1
//7
//13
//19

// How it Works

//from num in numbers → takes each element from the collection.

//where num % 2 == 0 → filters the numbers that are even.

//select num → selects (returns) the filtered numbers.

//numbers.Where(num => num % 2 != 0) → method syntax that does the same thing using a lambda expression.

//🔍 Common LINQ Methods
//Method	Description	Example
//Where()	Filters elements	numbers.Where(n => n > 5)
//Select()	Projects each element into a new form students.Select(s => s.Name)
//OrderBy()   Sorts ascending	numbers.OrderBy(n => n)
//OrderByDescending()	Sorts descending	numbers.OrderByDescending(n => n)
//GroupBy()	Groups data	students.GroupBy(s => s.Department)
//Count()	Counts elements	numbers.Count()
//Sum()	Adds up numbers	numbers.Sum()
//Average()	Finds the mean	numbers.Average()
//🎯 Example 2: LINQ on a List of Objects
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Sujit", Marks = 85 },
            new Student { Name = "Sushan", Marks = 72 },
            new Student { Name = "Ajit", Marks = 90 },
        };

        var topStudents = from s in students
                          where s.Marks > 80
                          select s.Name;

        Console.WriteLine("Top Students:");
        foreach (var name in topStudents)
            Console.WriteLine(name);
    }
}
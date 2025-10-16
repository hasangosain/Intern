using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public char Grade { get; set; } // Grade as A, B, C, D
    public string Major { get; set; }
}

class Program
{
    static void Main()
    {
        //  Create a list of students
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Sujit", Age = 20, Grade = 'A', Major = "Computer Science" },
            new Student { Name = "Sushan", Age = 22, Grade = 'B', Major = "Computer Science" },
            new Student { Name = "Ajit", Age = 21, Grade = 'A', Major = "Business" },
            new Student { Name = "Ramesh", Age = 23, Grade = 'C', Major = "Business" },
            new Student { Name = "Bikash", Age = 19, Grade = 'D', Major = "Engineering" }
        };

        //  Print all students
        Console.WriteLine(" All Students ");
        foreach (var s in students)
        {
            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}, Grade: {s.Grade}, Major: {s.Major}");
        }

        //  Filter students by Grade A
        var aStudents = from s in students
                        where s.Grade == 'A'
                        select s;

        Console.WriteLine("\n A Grade Students ");
        foreach (var s in aStudents)
        {
            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}, Grade: {s.Grade}, Major: {s.Major}");
        }

        //  Sort students by Age
        var sortedByAge = from s in students
                          orderby s.Age
                          select s;

        Console.WriteLine("\n Students Sorted by Age ");
        foreach (var s in sortedByAge)
        {
            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}, Grade: {s.Grade}, Major: {s.Major}");
        }

        //  Group students by Major
        var groupedByMajor = from s in students
                             group s by s.Major;

        Console.WriteLine("\n Students Grouped by Major ");
        foreach (var group in groupedByMajor)
        {
            Console.WriteLine($"\nMajor: {group.Key}");
            foreach (var s in group)
            {
                Console.WriteLine($"  Name: {s.Name}, Age: {s.Age}, Grade: {s.Grade}, Major: {s.Major}");
            }
        }

        //  Calculate average grade (A=4, B=3, C=2, D=1)
        var gradePoints = new Dictionary<char, int>
        {
            { 'A', 4 },
            { 'B', 3 },
            { 'C', 2 },
            { 'D', 1 }
        };

        double avgGradeValue = students.Average(s => gradePoints[s.Grade]);

        Console.WriteLine($"\n Average Grade Point: {avgGradeValue:F2} ===");

        // Optional: Convert back to letter grade
        char avgLetter = avgGradeValue >= 3.5 ? 'A' :
                         avgGradeValue >= 2.5 ? 'B' :
                         avgGradeValue >= 1.5 ? 'C' : 'D';

        Console.WriteLine($" Approximate Average Grade: {avgLetter} ");
    }
}

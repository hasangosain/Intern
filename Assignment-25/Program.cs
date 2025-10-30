using System;
using System.Linq;
using Assignment25.Data;
using Assignment25.Models;

class Program
{
    static void Main()
    {
        using var db = new SchoolContext();
        db.Database.EnsureDeleted();  // for demo (optional)
        db.Database.EnsureCreated();

        //  Add Students 
        var ram = new Student { Name = "Ram Shrestha" };
        var hari = new Student { Name = "Hari Basnet" };
        var sita = new Student { Name = "Sita Adhikari" };

        // Add Courses 
        var math = new Course { CourseName = "Mathematics" };
        var science = new Course { CourseName = "Science" };
        var english = new Course { CourseName = "English" };

        //  Many-to-Many Relationship 
        ram.Courses.Add(math);
        ram.Courses.Add(science);
        hari.Courses.Add(science);
        sita.Courses.Add(english);

        db.Students.AddRange(ram, hari, sita);
        db.Courses.AddRange(math, science, english);

        //  One-to-Many Relationship (Grades) 
        db.Grades.AddRange(
            new Grade { Student = ram, Subject = "Mathematics", Score = 85 },
            new Grade { Student = ram, Subject = "Science", Score = 90 },
            new Grade { Student = hari, Subject = "Science", Score = 78 },
            new Grade { Student = sita, Subject = "English", Score = 88 }
        );

        db.SaveChanges();
        Console.WriteLine("✅ Database created and data inserted.\n");

        
        //  QUERIES
        

        // 1️⃣ Students enrolled in a specific course
        string targetCourse = "Science";
        var enrolledStudents = db.Courses
            .Where(c => c.CourseName == targetCourse)
            .SelectMany(c => c.Students)
            .Select(s => s.Name)
            .ToList();

        Console.WriteLine($"Students enrolled in {targetCourse}:");
        enrolledStudents.ForEach(Console.WriteLine);

        // 2️⃣ Average grades per course
        var avgGrades = db.Grades
            .GroupBy(g => g.Subject)
            .Select(g => new { Subject = g.Key, Avg = g.Average(x => x.Score) })
            .ToList();

        Console.WriteLine("\nAverage Grades per Course:");
        foreach (var g in avgGrades)
            Console.WriteLine($"{g.Subject}: {g.Avg:F2}");

        // 3️⃣ Student with highest GPA
        var topStudent = db.Grades
            .GroupBy(g => g.Student.Name)
            .Select(g => new { Student = g.Key, GPA = g.Average(x => x.Score) })
            .OrderByDescending(g => g.GPA)
            .FirstOrDefault();

        Console.WriteLine($"\nStudent with Highest GPA: {topStudent.Student} ({topStudent.GPA:F2})");
    }
}

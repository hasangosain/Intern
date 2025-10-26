using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Faculty { get; set; }

    public Student(string name, int age, string faculty)
    {
        Name = name;
        Age = age;
        Faculty = faculty;
    }

    // Convert student data to CSV format
    public string ToCsv()
    {
        return $"{Name},{Age},{Faculty}";
    }
}

class StudentRecordsSystem
{
    private List<Student> students = new List<Student>();
    private string filePath = "students.csv";

    // Add new student
    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine("✅ Student added successfully!");
    }

    // Display all students
    public void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No student records found.");
            return;
        }

        Console.WriteLine("\n Student Records ");
        foreach (var s in students)
        {
            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}, Faculty: {s.Faculty}");
        }
    }

    // Save records to CSV
    public void SaveToCsv()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Name,Age,Faculty"); // Header
            foreach (var s in students)
            {
                writer.WriteLine(s.ToCsv());
            }
        }
        Console.WriteLine($"\n📁 Student records saved to {filePath}");
    }
}

class Program
{
    static void Main()
    {
        StudentRecordsSystem system = new StudentRecordsSystem();
        int choice;

        do
        {
            Console.WriteLine("\n STUDENT RECORDS SYSTEM ");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Save to CSV");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice)) choice = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter faculty: ");
                    string faculty = Console.ReadLine();

                    system.AddStudent(new Student(name, age, faculty));
                    break;

                case 2:
                    system.DisplayStudents();
                    break;

                case 3:
                    system.SaveToCsv();
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        } while (choice != 4);
    }
}

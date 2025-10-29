using System;
using System.Linq;

namespace Assignment24
{
    class Program
    {
        static void Main()
        {
            using var db = new SchoolContext();
            db.Database.EnsureCreated();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n School Student Management ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. List All Students");
                Console.WriteLine("3. Search by Course");
                Console.WriteLine("4. Sort by Enrollment Date");
                Console.WriteLine("5. Update Student Info");
                Console.WriteLine("6️. Delete Student");
                Console.WriteLine("7️. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddStudent(db); break;
                    case "2": ListStudents(db); break;
                    case "3": SearchByCourse(db); break;
                    case "4": SortByDate(db); break;
                    case "5": UpdateStudent(db); break;
                    case "6": DeleteStudent(db); break;
                    case "7": running = false; break;
                    default: Console.WriteLine("❌ Invalid choice."); break;
                }
            }
        }

        static void AddStudent(SchoolContext db)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            var student = new Student { Name = name, Age = age, Course = course, Email = email };
            db.Students.Add(student);
            db.SaveChanges();
            Console.WriteLine("✅ Student added successfully!");
        }

        static void ListStudents(SchoolContext db)
        {
            var students = db.Students.ToList();
            Console.WriteLine("\n All Students ");
            foreach (var s in students)
                Console.WriteLine($"{s.StudentId}. {s.Name} ({s.Age}) - {s.Course} | {s.Email} | Joined: {s.EnrollmentDate:d}");
        }

        static void SearchByCourse(SchoolContext db)
        {
            Console.Write("Enter course name: ");
            string course = Console.ReadLine();
            var results = db.Students.Where(s => s.Course.ToLower().Contains(course.ToLower())).ToList();

            if (results.Any())
            {
                Console.WriteLine("\n Matching Students ");
                foreach (var s in results)
                    Console.WriteLine($"{s.StudentId}. {s.Name} - {s.Course}");
            }
            else
                Console.WriteLine("⚠️ No students found for that course.");
        }

        static void SortByDate(SchoolContext db)
        {
            var sorted = db.Students.OrderBy(s => s.EnrollmentDate).ToList();
            Console.WriteLine("\n Students Sorted by Enrollment Date ");
            foreach (var s in sorted)
                Console.WriteLine($"{s.StudentId}. {s.Name} - Joined: {s.EnrollmentDate:d}");
        }

        static void UpdateStudent(SchoolContext db)
        {
            Console.Write("Enter Student ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var student = db.Students.Find(id);
            if (student == null)
            {
                Console.WriteLine("❌ Student not found.");
                return;
            }

            Console.Write($"New Name ({student.Name}): ");
            string name = Console.ReadLine();
            Console.Write($"New Age ({student.Age}): ");
            string ageStr = Console.ReadLine();
            Console.Write($"New Course ({student.Course}): ");
            string course = Console.ReadLine();
            Console.Write($"New Email ({student.Email}): ");
            string email = Console.ReadLine();

            if (!string.IsNullOrEmpty(name)) student.Name = name;
            if (int.TryParse(ageStr, out int newAge)) student.Age = newAge;
            if (!string.IsNullOrEmpty(course)) student.Course = course;
            if (!string.IsNullOrEmpty(email)) student.Email = email;

            db.SaveChanges();
            Console.WriteLine("✅ Student updated successfully!");
        }

        static void DeleteStudent(SchoolContext db)
        {
            Console.Write("Enter Student ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            var student = db.Students.Find(id);
            if (student == null)
            {
                Console.WriteLine("❌ Student not found.");
                return;
            }

            db.Students.Remove(student);
            db.SaveChanges();
            Console.WriteLine("🗑️ Student deleted successfully!");
        }
    }
}

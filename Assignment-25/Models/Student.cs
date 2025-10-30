using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Assignment25.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;

        // Navigation
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }

    public class Grade
    {
        public int GradeId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public double Score { get; set; }

        // Foreign Key
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}

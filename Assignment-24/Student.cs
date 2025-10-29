using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Assignment24
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(16, 80)]
        public int Age { get; set; }

        [Required]
        public string Course { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime EnrollmentDate { get; set; } = DateTime.Now;
    }
}
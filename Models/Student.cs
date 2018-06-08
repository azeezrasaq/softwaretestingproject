using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace softwareproject.Models
{
    public class Student
    {
        public int studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace softwareproject.Models
{
    public class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public int totalcredit { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
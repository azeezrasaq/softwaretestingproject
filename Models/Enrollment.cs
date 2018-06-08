using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace softwareproject.Models
{
    public class Enrollment
    {
        public int enrollmentId { get; set; }
        public int courseId { get; set; }
        public int studentId { get; set; }
        public decimal? grade { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }
}
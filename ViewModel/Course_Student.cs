using softwareproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace softwareproject.ViewModel
{
    public class Course_Student
    {
        public Course courses { get; set; }
        public List<Student> students { get; set; }
    }
} 


using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace softwareproject.Models
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {

        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>{
            
            new Student{firstName = "Taye", lastName = "Balogun", EnrollmentDate = DateTime.Parse("2018-04-21")},  
            new Student{firstName="Gbenga", lastName= "Rasheed", EnrollmentDate = DateTime.Parse("2018-04-21")}
            };
            foreach(var temp in students){
                context.Students.Add(temp);

            }
            context.SaveChanges();

            var courses = new List<Course>{
            new Course{courseName = "Java", totalcredit=5},
            new Course{courseName = "C#", totalcredit=5}
            
            };
            foreach(var temp in courses){
                context.Courses.Add(temp);
            
            }
            context.SaveChanges();

            var enrollments = new List<Enrollment>(){
            
            new Enrollment{studentId =1, courseId =1, grade=5},
            new Enrollment{studentId = 1, courseId =2, grade=6}

            };
            foreach(var temp in enrollments){
            context.Enrollments.Add(temp);
            }
            context.SaveChanges();

        }
    }
}
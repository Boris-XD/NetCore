using System;
using ReadData.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllInstructors();
        }

        public static void GetAllComments()
        {
            Console.WriteLine("Read Data");
            using(var db = new CoursesDbContext())
            {
                var courses = db.Courses.Include(course => course.ListComments);
                foreach(var course in courses)
                {
                    Console.WriteLine(course.Titulo);
                    foreach (var item in course.ListComments)
                    {
                        Console.WriteLine("______________________");
                        Console.WriteLine(item.Comments);
                        Console.WriteLine("______________________");
                    }
                }
            }
        }

        public static void GetAllInstructors()
        {
            Console.WriteLine("All instructors by Course");
            using(var db = new CoursesDbContext())
            {
                var courses = db.Courses.Include(courses => courses.InstructorLink)
                                        .ThenInclude(ci => ci.Instructor);
                foreach(var course in courses)
                {
                    Console.WriteLine(course.Titulo);
                    foreach (var item in course.InstructorLink)
                    {
                        Console.WriteLine("______________________");
                        Console.WriteLine(item.Instructor.Name);
                        Console.WriteLine("______________________");
                    }
                }
            }
        }
    }
}

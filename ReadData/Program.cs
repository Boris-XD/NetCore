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
    }
}

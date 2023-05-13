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
                var courses = db.Courses.AsNoTracking();
                foreach(var course in courses)
                {
                    Console.WriteLine(course.Titulo);
                }
            }
        }
    }
}

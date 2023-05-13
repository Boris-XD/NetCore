using System;

namespace ReadData.entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Description { get; set; }
        public DateTime? DatePublish { get; set; }
    }
}
using System.Collections.Generic;
using System;

namespace ReadData.entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Description { get; set; }
        public DateTime? DatePublish { get; set; }
        public Price Price { get; set; }
        public ICollection<Commentary> ListComments { get; set; }
    }
}
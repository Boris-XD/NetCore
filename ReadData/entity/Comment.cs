using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData.entity
{
    [Table("Comments")]
    public class Commentary
    {
        public int Id { get; set; }
        public string Student { get; set; }
        public int Score { get; set; }
        [Column("Comment")]
        public string Comments { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
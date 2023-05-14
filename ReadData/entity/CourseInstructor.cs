namespace ReadData.entity
{
    public class CourseInstructor
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        public Course Curso { get; set; }
        public Instructor Instructor { get; set; }
    }
}
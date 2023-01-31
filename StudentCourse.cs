namespace Tutorial_1_How_to_add_Controller_.Models
{
    public class StudentCourse
    {
        public int Id{get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; } // Worked as foreign Key
        public Course Course { get; set; }  // Worked as foreign Key

    }
}

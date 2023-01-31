namespace Tutorial_1_How_to_add_Controller_.Models
{
    public class Student//table
    {
        public int Id { get; set; }//primary key
        public string Name { get; set; }
        public DateTime Enrolled { get; set; }

        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}

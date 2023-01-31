using Microsoft.EntityFrameworkCore;
using Tutorial_1_How_to_add_Controller_.Models;

namespace Tutorial_1_How_to_add_Controller_.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Student> Students  {get; set;}
        public DbSet<Course> Courses { get; set;}
    }
}

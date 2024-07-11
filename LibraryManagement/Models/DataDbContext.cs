using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Models
{
    public class DataDbContext: DbContext
    {
        public DataDbContext(DbContextOptions options) : base (options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs{ get; set; }
        public DbSet<Book> Books { get; set; }
    }
}

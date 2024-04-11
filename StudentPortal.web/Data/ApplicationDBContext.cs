using Microsoft.EntityFrameworkCore;
using StudentPortal.web.Models.Entites;

namespace StudentPortal.web.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
        public DbSet<Student> students { get; set; }
    }
}

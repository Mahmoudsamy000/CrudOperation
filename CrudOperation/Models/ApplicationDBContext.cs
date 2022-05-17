using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
           
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Genres> Genres { get; set; }


    }
}

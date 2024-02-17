using Microsoft.EntityFrameworkCore;

namespace EventManagement.Entities
{

    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Event> events { get; set; }
    }
}

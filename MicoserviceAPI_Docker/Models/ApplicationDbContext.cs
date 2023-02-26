using Microsoft.EntityFrameworkCore;

namespace MicoserviceAPI_Docker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}

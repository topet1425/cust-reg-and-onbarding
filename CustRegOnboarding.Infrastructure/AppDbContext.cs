using Microsoft.EntityFrameworkCore;
using CustRegOnboarding.Domain;

namespace CustRegOnboarding.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
    }
}

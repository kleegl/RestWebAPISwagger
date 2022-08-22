using Microsoft.EntityFrameworkCore;
using Models.Implementations;

namespace Models.Implementations
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        private readonly IConfiguration _iConfiguration;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(_iConfiguration.GetConnectionString("DefaultConnection"));
        }

        public ApplicationDbContext(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
        }
    }
}
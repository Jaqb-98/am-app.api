using Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :
            base(options)
        {
        }

        public DbSet<Checkpoint> Checkpoints => Set<Checkpoint>();

        public DbSet<Question> Questions => Set<Question>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

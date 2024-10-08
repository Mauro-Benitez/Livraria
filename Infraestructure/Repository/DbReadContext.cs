using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository
{
    public class DbReadContext : DbContext
    {
        public DbReadContext(DbContextOptions<DbReadContext> options) : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}

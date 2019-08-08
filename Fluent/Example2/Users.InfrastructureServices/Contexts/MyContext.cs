using Microsoft.EntityFrameworkCore;
using Users.Infrastructure.Models;
using Users.InfrastructureServices.Configurations;

namespace Users.InfrastructureServices.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public virtual DbSet<InfrastructureUser> Users { get; set; }

        public virtual DbSet<ReqestLogEntry> ReqestLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                 .ApplyConfiguration(new UserConfiguration())
                 .ApplyConfiguration(new ReqestLogEntryConfiguration());

            base.OnModelCreating(modelBuilder);
        }
           
    }
}

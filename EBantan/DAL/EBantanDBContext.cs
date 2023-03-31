using EBantan.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBantan.DAL
{
    public class EBantanDBContext : DbContext
    {
        public EBantanDBContext(DbContextOptions<EBantanDBContext> options)
       : base(options)
        {
        }
        public DbSet<Test> Test { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>()
                  .HasKey(p => p.Id);
        }
    }
}

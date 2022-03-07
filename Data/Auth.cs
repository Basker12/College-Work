using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace WebApplication.Data
{
    public class Auth:DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        public Auth(DbContextOptions<Auth> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasKey(e => e.userId);
                entity.Property(e => e.userId);
                entity.Property(e => e.username).HasMaxLength(20);
                entity.Property(e => e.password).HasMaxLength(15);
                
                //Test Data

                entity.HasData(new AppUser()
                {
                    userId = 1,
                    username = "Kacper2022",
                    password = "iLoveMax123"
                });
            });
        }
    }
}

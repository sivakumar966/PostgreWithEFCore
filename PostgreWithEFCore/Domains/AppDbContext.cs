using Microsoft.EntityFrameworkCore;

namespace PostgreWithEFCore.Domains;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Team> Teams { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<DriverMedia> DriverMedias { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Driver>(entity =>
        {
            // One to Many
            entity.HasOne(t => t.Team)
            .WithMany(d => d.Drivers)
            .OnDelete(DeleteBehavior.Restrict);

            // One to One
            entity.HasOne(m => m.DriverMedia)
            .WithOne(d => d.Driver);
        });
    }
}

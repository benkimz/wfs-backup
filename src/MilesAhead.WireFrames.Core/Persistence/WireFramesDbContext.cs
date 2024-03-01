using Microsoft.EntityFrameworkCore;

namespace MilesAhead.WireFrames.Core;

public class WireFramesDbContext : DbContext
{
    public WireFramesDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("render");
        modelBuilder.Entity<PrimeRoot>()
            .HasIndex(e => e.RootName)
            .IsUnique();
    }
    public DbSet<PrimeRoot> PrimeRoots { get; set; }
    public DbSet<WireFrame> WireFrames { get; set; }
}

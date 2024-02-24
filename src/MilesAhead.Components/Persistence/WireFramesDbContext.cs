using Microsoft.EntityFrameworkCore;

namespace MilesAhead.Components;

public class WireFramesDbContext : DbContext
{
    public WireFramesDbContext(DbContextOptions options) : base(options)
    {
    }
    // lets set the schema name to "MilesAhead" in the model builder
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("render");
    }
    public DbSet<PrimeRoot> PrimeRoots { get; set; }
    public DbSet<WireFrame> WireFrames { get; set; }
}

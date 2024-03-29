﻿using Microsoft.EntityFrameworkCore;

namespace WireFrames.Core;

public class WireFramesDbContext : DbContext
{
    public WireFramesDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("render");
    }
    public DbSet<PrimeRoot> PrimeRoots { get; set; }
    public DbSet<WireFrame> WireFrames { get; set; }
}

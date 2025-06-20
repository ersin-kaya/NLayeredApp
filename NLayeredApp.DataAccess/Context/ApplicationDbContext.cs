using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;
using NLayeredApp.DataAccess.Seeds;

namespace NLayeredApp.DataAccess.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<CategoryFeatureType> CategoryFeatureTypes => Set<CategoryFeatureType>();
    public DbSet<Feature> Features => Set<Feature>();
    public DbSet<FeatureType> FeatureTypes => Set<FeatureType>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductFeatureType> ProductFeatureTypes => Set<ProductFeatureType>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        SeedDataManager.ApplySeedData(modelBuilder);
    }
}
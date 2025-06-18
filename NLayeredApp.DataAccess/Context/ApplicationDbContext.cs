using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;
using NLayeredApp.DataAccess.Configurations.Identity;
using NLayeredApp.DataAccess.Identity;
using NLayeredApp.DataAccess.Interceptors;
using NLayeredApp.DataAccess.Seeds;

namespace NLayeredApp.DataAccess.Context;

public class ApplicationDbContext : IdentityDbContext<
    ApplicationUser,
    ApplicationRole,
    int,
    IdentityUserClaim<int>,
    ApplicationUserRole,
    IdentityUserLogin<int>,
    IdentityRoleClaim<int>,
    IdentityUserToken<int>>
{
    private readonly AuditableEntityInterceptor _auditInterceptor = null!;
    private readonly SoftDeleteInterceptor _softDeleteInterceptor = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        AuditableEntityInterceptor auditInterceptor,
        SoftDeleteInterceptor softDeleteInterceptor) : base(options)
    {
        _auditInterceptor = auditInterceptor;
        _softDeleteInterceptor = softDeleteInterceptor;
    }

    // Domain entities
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Feature> Features => Set<Feature>();
    public DbSet<FeatureType> FeatureTypes => Set<FeatureType>();
    public DbSet<CategoryFeatureType> CategoryFeatureTypes => Set<CategoryFeatureType>();
    public DbSet<ProductFeatureType> ProductFeatureTypes => Set<ProductFeatureType>();
    
    // Identity
    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditInterceptor, _softDeleteInterceptor);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Identity table name configurations
        IdentityTableConfiguration.ConfigureIdentityTables(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        SeedDataManager.ApplySeedData(modelBuilder);
    }
}
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;
using NLayeredApp.Core.Interfaces.Services.Auth;
using NLayeredApp.DataAccess.Configurations.Identity;
using NLayeredApp.DataAccess.Identity;
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
    private readonly ICurrentUserService? _currentUserService;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        ICurrentUserService? currentUserService) : base(options)
    {
        _currentUserService = currentUserService;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Identity table name configurations
        IdentityTableConfiguration.ConfigureIdentityTables(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        SeedDataManager.ApplySeedData(modelBuilder);
    }
}
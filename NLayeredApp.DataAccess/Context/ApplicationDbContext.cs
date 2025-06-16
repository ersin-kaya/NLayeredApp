using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Common;
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

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var currentUsername = _currentUserService?.Username ?? "System";
        var currentTime = DateTimeOffset.Now;
        
        // Handle audit fields
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is AuditableEntity &&
                        e.State is EntityState.Added or EntityState.Modified);

        foreach (var entry in entries)
        {
            var entity = (AuditableEntity)entry.Entity;

            if (entry.State == EntityState.Added)
            {
                entity.CreatedAt = currentTime;
                entity.CreatedBy = currentUsername;
            }
            else
            {
                entity.LastModifiedAt = currentTime;
                entity.LastModifiedBy = currentUsername;
            }
        }
        
        // Handle soft delete
        var deletedEntries = ChangeTracker.Entries()
            .Where(e => e.Entity is ISoftDeletable && 
                        e.State == EntityState.Deleted);

        foreach (var entry in deletedEntries)
        {
            entry.State = EntityState.Modified;
            var entity = (ISoftDeletable)entry.Entity;
            entity.IsDeleted = true;
            entity.DeletedAt = currentTime;
            entity.DeletedBy = currentUsername;
        }
        
        return await base.SaveChangesAsync(cancellationToken);
    }
}
using Microsoft.AspNetCore.Identity;
using NLayeredApp.Core.Entities;
using NLayeredApp.DataAccess.Identity;

namespace NLayeredApp.DataAccess.Seeds;

public static class SeedHelpers
{
    // Identity
    public static ApplicationRole CreateRole(int id, string name, string? description = null)
    {
        return new ApplicationRole
        {
            Id = id,
            Name = name,
            NormalizedName = name.ToUpperInvariant(),
            Description = description,
            IsActive = SeedConstants.Common.IsActive,
            CreatedAt = SeedConstants.Common.CreatedAt
        };
    }

    public static ApplicationUser CreateUser(int id, string name, string email, bool emailConfirmed, string firstName, string lastName, string password)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        var user = new ApplicationUser
        {
            Id = id,
            UserName = name,
            NormalizedUserName = name.ToUpperInvariant(),
            Email = email,
            NormalizedEmail = email.ToUpperInvariant(),
            EmailConfirmed = emailConfirmed,
            FirstName = firstName,
            LastName = lastName,
            IsActive = SeedConstants.Common.IsActive,
            SecurityStamp = Guid.NewGuid().ToString(),
            CreatedAt = SeedConstants.Common.CreatedAt,
            CreatedBy = SeedConstants.Common.CreatedBy,
        };
        user.PasswordHash = hasher.HashPassword(user, password);
        return user;
    }
    
    // Domain entities
    public static Category CreateCategory(SeedConstants.CategoryIds id, string name, string? description = null)
    {
        return new Category
        {
            Id = (int)id,
            Name = name,
            Description = description,
            IsActive = SeedConstants.Common.IsActive,
            CreatedAt = SeedConstants.Common.CreatedAt,
            CreatedBy = SeedConstants.Common.CreatedBy
        };
    }
    
    public static FeatureType CreateFeatureType(SeedConstants.FeatureTypeIds id, string name)
    {
        return new FeatureType
        {
            Id = (int)id,
            Name = name
        };
    }
    
    public static CategoryFeatureType CreateCategoryFeatureType(SeedConstants.CategoryIds categoryId, SeedConstants.FeatureTypeIds featureTypeId, string label, bool isRequired = false)
    {
        return new CategoryFeatureType
        {
            CategoryId = (int)categoryId,
            FeatureTypeId = (int)featureTypeId,
            Label = label,
            IsRequired = isRequired
        };
    }
    
    public static Feature CreateFeature<T>(T id, string value, SeedConstants.CategoryIds categoryId, SeedConstants.FeatureTypeIds featureTypeId) where T : Enum
    {
        return new Feature
        {
            Id = Convert.ToInt32(id),
            Value = value,
            CategoryId = (int)categoryId,
            FeatureTypeId = (int)featureTypeId
        };
    }
    
    public static Product CreateProduct<T>(T id, string name, string description, decimal price, int stock, SeedConstants.CategoryIds categoryId) where T : Enum
    {
        return new Product
        {
            Id = Convert.ToInt32(id),
            Name = name,
            Description = description,
            Price = price,
            Stock = stock,
            IsActive = SeedConstants.Common.IsActive,
            CategoryId = (int)categoryId,
            CreatedAt = SeedConstants.Common.CreatedAt,
            CreatedBy = SeedConstants.Common.CreatedBy
        };
    }
    
    public static ProductFeatureType CreateProductFeatureType<TProductId, TFeatureId>(TProductId productId, SeedConstants.CategoryIds categoryId, SeedConstants.FeatureTypeIds featureTypeId, TFeatureId featureId) 
        where TProductId : Enum 
        where TFeatureId : Enum
    {
        return new ProductFeatureType
        {
            ProductId = Convert.ToInt32(productId),
            CategoryId = (int)categoryId,
            FeatureTypeId = (int)featureTypeId,
            FeatureId = Convert.ToInt32(featureId)
        };
    }
}
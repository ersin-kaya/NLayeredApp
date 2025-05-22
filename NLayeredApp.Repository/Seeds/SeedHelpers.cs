using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Seeds;

public static class SeedHelpers
{
    public static Category CreateCategory(int id, string name, string? description = null)
    {
        return new Category
        {
            Id = id,
            Name = name,
            Description = description,
            IsActive = SeedConstants.Common.IsActive,
            CreatedAt = SeedConstants.Common.CreatedAt,
            CreatedBy = SeedConstants.Common.CreatedBy
        };
    }
    
    public static FeatureType CreateFeatureType(int id, string name)
    {
        return new FeatureType
        {
            Id = id,
            Name = name
        };
    }
    
    public static CategoryFeatureType CreateCategoryFeatureType(int categoryId, int featureTypeId, string label, bool isRequired = false)
    {
        return new CategoryFeatureType
        {
            CategoryId = categoryId,
            FeatureTypeId = featureTypeId,
            Label = label,
            IsRequired = isRequired
        };
    }
    
    public static Feature CreateFeature(int id, string value, int categoryId, int featureTypeId)
    {
        return new Feature
        {
            Id = id,
            Value = value,
            CategoryId = categoryId,
            FeatureTypeId = featureTypeId
        };
    }
    
    public static Product CreateProduct(int id, string name, string description, decimal price, int stock, int categoryId)
    {
        return new Product
        {
            Id = id,
            Name = name,
            Description = description,
            Price = price,
            Stock = stock,
            IsActive = SeedConstants.Common.IsActive,
            CategoryId = categoryId,
            CreatedAt = SeedConstants.Common.CreatedAt,
            CreatedBy = SeedConstants.Common.CreatedBy
        };
    }
    
    public static ProductFeatureType CreateProductFeatureType(int productId, int categoryId, int featureTypeId, int featureId)
    {
        return new ProductFeatureType
        {
            ProductId = productId,
            CategoryId = categoryId,
            FeatureTypeId = featureTypeId,
            FeatureId = featureId
        };
    }
}
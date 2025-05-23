using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Seeds;

public static class CategoryFeatureTypeSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryFeatureType>().HasData(
            // Electronics
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                "Color"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage,
                "Storage Capacity"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory,
                "RAM"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Processor,
                "Processor"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize,
                "Screen Size"
            ),
            
            // Clothing
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color,
                "Color"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size,
                "Size"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material,
                "Material"
            ),
            
            // Home and Living
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color,
                "Color"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material,
                "Material"
            )
        );
    }
}
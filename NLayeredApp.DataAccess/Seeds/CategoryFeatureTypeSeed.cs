using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Seeds;

public static class CategoryFeatureTypeSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryFeatureType>().HasData(
            // Electronics
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color,
                "Color"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Storage,
                "Storage Capacity"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Memory,
                "RAM"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Processor,
                "Processor"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.ScreenSize,
                "Screen Size"
            ),
            
            // Clothing
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Color,
                "Color"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Size,
                "Size"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material,
                "Material"
            ),
            
            // Home and Living
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Color,
                "Color"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material,
                "Material"
            )
        );
    }
}
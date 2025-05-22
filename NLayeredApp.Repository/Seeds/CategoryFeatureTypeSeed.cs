using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Seeds;

public static class CategoryFeatureTypeSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryFeatureType>().HasData(
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                "Color"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage,
                "Storage Capacity",
                SeedConstants.Common.IsRequired
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Ram,
                "RAM",
                SeedConstants.Common.IsRequired
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
            
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color,
                "Color",
                SeedConstants.Common.IsRequired
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size,
                "Size",
                SeedConstants.Common.IsRequired
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material,
                "Fabric"
            ),
            
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color,
                "Color"
            ),
            SeedHelpers.CreateCategoryFeatureType(
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material,
                "Material",
                SeedConstants.Common.IsRequired
            )
        );
    }
}
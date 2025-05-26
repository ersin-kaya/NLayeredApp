using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Seeds;

public static class FeatureTypeSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FeatureType>().HasData(
            SeedHelpers.CreateFeatureType(SeedConstants.FeatureTypeIds.Color, "Color"),
            SeedHelpers.CreateFeatureType(SeedConstants.FeatureTypeIds.Size, "Size"),
            SeedHelpers.CreateFeatureType(SeedConstants.FeatureTypeIds.Material, "Material"),
            SeedHelpers.CreateFeatureType(SeedConstants.FeatureTypeIds.Storage, "Storage"),
            SeedHelpers.CreateFeatureType(SeedConstants.FeatureTypeIds.Memory, "Memory"),
            SeedHelpers.CreateFeatureType(SeedConstants.FeatureTypeIds.Processor, "Processor"),
            SeedHelpers.CreateFeatureType(SeedConstants.FeatureTypeIds.ScreenSize, "Screen Size")
        );
    }
}
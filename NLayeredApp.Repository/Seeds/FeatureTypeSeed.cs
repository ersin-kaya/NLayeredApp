using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Seeds;

public static class FeatureTypeSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FeatureType>().HasData(
            SeedHelpers.CreateFeatureType((int)SeedConstants.FeatureTypeIds.Color, "Color"),
            SeedHelpers.CreateFeatureType((int)SeedConstants.FeatureTypeIds.Size, "Size"),
            SeedHelpers.CreateFeatureType((int)SeedConstants.FeatureTypeIds.Material, "Material"),
            SeedHelpers.CreateFeatureType((int)SeedConstants.FeatureTypeIds.Storage, "Storage"),
            SeedHelpers.CreateFeatureType((int)SeedConstants.FeatureTypeIds.Ram, "RAM"),
            SeedHelpers.CreateFeatureType((int)SeedConstants.FeatureTypeIds.Processor, "Processor"),
            SeedHelpers.CreateFeatureType((int)SeedConstants.FeatureTypeIds.ScreenSize, "Screen Size")
        );
    }
}
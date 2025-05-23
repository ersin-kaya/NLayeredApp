using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Seeds;

public static class FeatureSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Feature>().HasData(
            // Electronics - Colors
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Black,
                "Black",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.White,
                "White",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Silver,
                "Silver",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color
            ),

            // Electronics - Storage Options
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.StorageIds.Gb64,
                "64 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.StorageIds.Gb128,
                "128 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.StorageIds.Gb256,
                "256 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.StorageIds.Gb512,
                "512 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage
            ),

            // Electronics - Memory Options
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.MemoryOptions.Gb4,
                "4 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.MemoryOptions.Gb8,
                "8 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.MemoryOptions.Gb16,
                "16 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.MemoryOptions.Gb32,
                "32 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory
            ),

            // Electronics - Processors
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.Processors.AmdRyzen5_7600X,
                "Amd Ryzen 5 7600X",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Processor
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.Processors.AmdRyzen7_9800X3D,
                "Amd Ryzen 7 9800X3D",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Processor
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.Processors.AmdRyzen9_9950X3D,
                "Amd Ryzen 9 9950X3D",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Processor
            ),

            // Electronics - Screen Sizes
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizes.Inch5_5,
                "5.5\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizes.Inch6_1,
                "6.1\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizes.Inch13_3,
                "13.3\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizes.Inch15_6,
                "15.6\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizes.Inch24,
                "24\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizes.Inch27,
                "27\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),

            // Clothing - Colors
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Colors.Red,
                "Red",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Colors.Blue,
                "Blue",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Colors.Green,
                "Green",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Colors.Yellow,
                "Yellow",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color
            ),

            // Clothing - Sizes
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Sizes.Xs,
                "XS",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Sizes.S,
                "S",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Sizes.M,
                "M",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Sizes.L,
                "L",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Sizes.Xl,
                "XL",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),

            // Clothing - Materials
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.Cotton,
                "Cotton",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.Polyester,
                "Polyester",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.Wool,
                "Wool",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.Denim,
                "Denim",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.Silk,
                "Silk",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.Leather,
                "Leather",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.FauxLeather,
                "Faux Leather",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.Linen,
                "Linen",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.Materials.Viscose,
                "Viscose",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),

            // Home and Living - Colors
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Colors.Beige,
                "Beige",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Colors.White,
                "White",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Colors.Brown,
                "Brown",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Colors.Gray,
                "Gray",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color
            ),

            // Home and Living - Materials
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Materials.Wood,
                "Wood",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Materials.Metal,
                "Metal",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Materials.Plastic,
                "Plastic",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Materials.Glass,
                "Glass",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.Materials.Ceramic,
                "Ceramic",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            )
        );
    }
}
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
                (int)SeedConstants.FeatureIds.Electronics.MemoryIds.Gb4,
                "4 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.MemoryIds.Gb8,
                "8 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.MemoryIds.Gb16,
                "16 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.MemoryIds.Gb32,
                "32 GB",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory
            ),

            // Electronics - Processors
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ProcessorIds.AmdRyzen5_7600X,
                "Amd Ryzen 5 7600X",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Processor
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ProcessorIds.AmdRyzen7_9800X3D,
                "Amd Ryzen 7 9800X3D",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Processor
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ProcessorIds.AmdRyzen9_9950X3D,
                "Amd Ryzen 9 9950X3D",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Processor
            ),

            // Electronics - Screen Sizes
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch5_5,
                "5.5\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch6_1,
                "6.1\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch13_3,
                "13.3\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch15_6,
                "15.6\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch24,
                "24\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch27,
                "27\"",
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.ScreenSize
            ),

            // Clothing - Colors
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Red,
                "Red",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Blue,
                "Blue",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Green,
                "Green",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Yellow,
                "Yellow",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color
            ),

            // Clothing - Sizes
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.SizeIds.Xs,
                "XS",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.SizeIds.S,
                "S",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.SizeIds.M,
                "M",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.SizeIds.L,
                "L",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.SizeIds.Xl,
                "XL",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size
            ),

            // Clothing - Materials
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Cotton,
                "Cotton",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Polyester,
                "Polyester",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Wool,
                "Wool",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Denim,
                "Denim",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Silk,
                "Silk",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Leather,
                "Leather",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.FauxLeather,
                "Faux Leather",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Linen,
                "Linen",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Viscose,
                "Viscose",
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material
            ),

            // Home and Living - Colors
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Beige,
                "Beige",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.ColorIds.White,
                "White",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Brown,
                "Brown",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Gray,
                "Gray",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color
            ),

            // Home and Living - Materials
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Wood,
                "Wood",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Metal,
                "Metal",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Plastic,
                "Plastic",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Glass,
                "Glass",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                (int)SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Ceramic,
                "Ceramic",
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material
            )
        );
    }
}
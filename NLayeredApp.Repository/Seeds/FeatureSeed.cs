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
                SeedConstants.FeatureIds.Electronics.ColorIds.Black,
                "Black",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ColorIds.White,
                "White",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ColorIds.Silver,
                "Silver",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color
            ),

            // Electronics - Storage Options
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.StorageIds.Gb64,
                "64 GB",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Storage
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.StorageIds.Gb128,
                "128 GB",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Storage
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.StorageIds.Gb256,
                "256 GB",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Storage
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.StorageIds.Gb512,
                "512 GB",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Storage
            ),

            // Electronics - Memory Options
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.MemoryIds.Gb4,
                "4 GB",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.MemoryIds.Gb8,
                "8 GB",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.MemoryIds.Gb16,
                "16 GB",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Memory
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.MemoryIds.Gb32,
                "32 GB",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Memory
            ),

            // Electronics - Processors
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ProcessorIds.AmdRyzen5_7600X,
                "Amd Ryzen 5 7600X",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Processor
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ProcessorIds.AmdRyzen7_9800X3D,
                "Amd Ryzen 7 9800X3D",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Processor
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ProcessorIds.AmdRyzen9_9950X3D,
                "Amd Ryzen 9 9950X3D",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Processor
            ),

            // Electronics - Screen Sizes
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch5_5,
                "5.5\"",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch6_1,
                "6.1\"",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch13_3,
                "13.3\"",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch15_6,
                "15.6\"",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch24,
                "24\"",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.ScreenSize
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Electronics.ScreenSizeIds.Inch27,
                "27\"",
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.ScreenSize
            ),

            // Clothing - Colors
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.ColorIds.Red,
                "Red",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.ColorIds.Blue,
                "Blue",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.ColorIds.Green,
                "Green",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.ColorIds.Yellow,
                "Yellow",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Color
            ),

            // Clothing - Sizes
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.SizeIds.Xs,
                "XS",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.SizeIds.S,
                "S",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.SizeIds.M,
                "M",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.SizeIds.L,
                "L",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Size
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.SizeIds.Xl,
                "XL",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Size
            ),

            // Clothing - Materials
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.Cotton,
                "Cotton",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.Polyester,
                "Polyester",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.Wool,
                "Wool",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.Denim,
                "Denim",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.Silk,
                "Silk",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.Leather,
                "Leather",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.FauxLeather,
                "Faux Leather",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.Linen,
                "Linen",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.Clothing.MaterialIds.Viscose,
                "Viscose",
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material
            ),

            // Home and Living - Colors
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Beige,
                "Beige",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.ColorIds.White,
                "White",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Brown,
                "Brown",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Color
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Gray,
                "Gray",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Color
            ),

            // Home and Living - Materials
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Wood,
                "Wood",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Metal,
                "Metal",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Plastic,
                "Plastic",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Glass,
                "Glass",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material
            ),
            SeedHelpers.CreateFeature(
                SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Ceramic,
                "Ceramic",
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material
            )
        );
    }
}
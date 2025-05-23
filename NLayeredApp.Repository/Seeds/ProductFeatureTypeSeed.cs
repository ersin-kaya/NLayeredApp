using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Seeds;

public static class ProductFeatureTypeSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductFeatureType>().HasData(
            // Electronics
            // Galaxy S25
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.GalaxyS25,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Silver
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.GalaxyS25,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage,
                (int)SeedConstants.FeatureIds.Electronics.StorageIds.Gb256
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.GalaxyS25,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory,
                (int)SeedConstants.FeatureIds.Electronics.MemoryIds.Gb16
            ),
            
            // Galaxy S24
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.GalaxyS24,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.White
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.GalaxyS24,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage,
                (int)SeedConstants.FeatureIds.Electronics.StorageIds.Gb128
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.GalaxyS24,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory,
                (int)SeedConstants.FeatureIds.Electronics.MemoryIds.Gb8
            ),
            
            // Logitech Mouse
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.LogitechMouse,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Keyboard
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.LogitechKeyboard,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Headset
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.LogitechHeadset,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Gamepad
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.LogitechGamepad,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Silver
            ),
            
            // Clothing
            // Polo Shirt
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.PoloShirt,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Red
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.PoloShirt,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.Clothing.Materials.Cotton
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.PoloShirt,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size,
                SeedConstants.FeatureIds.Clothing.Sizes.M
            ),
            
            // Blue Denim Jean
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.BlueDenimJean,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Blue
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.BlueDenimJean,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.Clothing.Materials.Denim
            ),
            
            // Running Shoes
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.RunningShoes,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Green
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.RunningShoes,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.Clothing.Materials.Polyester
            ),
            
            // Home and Living
            // Bookshelf
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Bookshelf,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.HomeAndLiving.Colors.Brown
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Bookshelf,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.HomeAndLiving.Materials.Wood
            ),
            
            // Dining Table Set
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.DiningTable,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.HomeAndLiving.Colors.Gray
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.DiningTable,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.HomeAndLiving.Materials.Ceramic
            ),
            
            // LED Floor Lamp
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.LedFloorLamp,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.HomeAndLiving.Colors.White
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.LedFloorLamp,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.HomeAndLiving.Materials.Metal
            )
        );
    }
}
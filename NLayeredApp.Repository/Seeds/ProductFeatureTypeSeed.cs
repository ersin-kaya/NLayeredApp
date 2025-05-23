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
                (int)SeedConstants.ProductIds.Electronics.GalaxyS25,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Silver
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.GalaxyS25,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage,
                (int)SeedConstants.FeatureIds.Electronics.StorageIds.Gb256
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.GalaxyS25,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory,
                (int)SeedConstants.FeatureIds.Electronics.MemoryIds.Gb16
            ),
            
            // Galaxy S24
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.GalaxyS24,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.White
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.GalaxyS24,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Storage,
                (int)SeedConstants.FeatureIds.Electronics.StorageIds.Gb128
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.GalaxyS24,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Memory,
                (int)SeedConstants.FeatureIds.Electronics.MemoryIds.Gb8
            ),
            
            // Logitech Mouse
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.LogitechMouse,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Keyboard
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.LogitechKeyboard,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Headset
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.LogitechHeadset,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Gamepad
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Electronics.LogitechGamepad,
                (int)SeedConstants.CategoryIds.Electronics,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Electronics.ColorIds.Silver
            ),
            
            // Clothing
            // Polo Shirt
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Clothing.PoloShirt,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Red
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Clothing.PoloShirt,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material,
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Cotton
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Clothing.PoloShirt,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Size,
                (int)SeedConstants.FeatureIds.Clothing.SizeIds.M
            ),
            
            // Blue Denim Jean
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Clothing.BlueDenimJean,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Blue
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Clothing.BlueDenimJean,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material,
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Denim
            ),
            
            // Running Shoes
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Clothing.RunningShoes,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.Clothing.ColorIds.Green
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.Clothing.RunningShoes,
                (int)SeedConstants.CategoryIds.Clothing,
                (int)SeedConstants.FeatureTypeIds.Material,
                (int)SeedConstants.FeatureIds.Clothing.MaterialIds.Polyester
            ),
            
            // Home and Living
            // Bookshelf
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.HomeAndLiving.Bookshelf,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Brown
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.HomeAndLiving.Bookshelf,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material,
                (int)SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Wood
            ),
            
            // Dining Table Set
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.HomeAndLiving.DiningTable,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Gray
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.HomeAndLiving.DiningTable,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material,
                (int)SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Ceramic
            ),
            
            // LED Floor Lamp
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.HomeAndLiving.LedFloorLamp,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Color,
                (int)SeedConstants.FeatureIds.HomeAndLiving.ColorIds.White
            ),
            SeedHelpers.CreateProductFeatureType(
                (int)SeedConstants.ProductIds.HomeAndLiving.LedFloorLamp,
                (int)SeedConstants.CategoryIds.HomeAndLiving,
                (int)SeedConstants.FeatureTypeIds.Material,
                (int)SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Metal
            )
        );
    }
}
using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Seeds;

public static class ProductFeatureTypeSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductFeatureType>().HasData(
            // Electronics
            // Galaxy S25
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.GalaxyS25,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Electronics.ColorIds.Silver
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.GalaxyS25,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Storage,
                SeedConstants.FeatureIds.Electronics.StorageIds.Gb256
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.GalaxyS25,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Memory,
                SeedConstants.FeatureIds.Electronics.MemoryIds.Gb16
            ),
            
            // Galaxy S24
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.GalaxyS24,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Electronics.ColorIds.White
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.GalaxyS24,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Storage,
                SeedConstants.FeatureIds.Electronics.StorageIds.Gb128
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.GalaxyS24,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Memory,
                SeedConstants.FeatureIds.Electronics.MemoryIds.Gb8
            ),
            
            // Logitech Mouse
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.LogitechMouse,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Keyboard
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.LogitechKeyboard,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Headset
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.LogitechHeadset,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Electronics.ColorIds.Black
            ),
            
            // Logitech Gamepad
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Electronics.LogitechGamepad,
                SeedConstants.CategoryIds.Electronics,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Electronics.ColorIds.Silver
            ),
            
            // Clothing
            // Polo Shirt
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Clothing.PoloShirt,
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Clothing.ColorIds.Red
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Clothing.PoloShirt,
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.Clothing.MaterialIds.Cotton
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Clothing.PoloShirt,
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Size,
                SeedConstants.FeatureIds.Clothing.SizeIds.M
            ),
            
            // Blue Denim Jean
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Clothing.BlueDenimJean,
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Clothing.ColorIds.Blue
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Clothing.BlueDenimJean,
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.Clothing.MaterialIds.Denim
            ),
            
            // Running Shoes
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Clothing.RunningShoes,
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.Clothing.ColorIds.Green
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.Clothing.RunningShoes,
                SeedConstants.CategoryIds.Clothing,
                SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.Clothing.MaterialIds.Polyester
            ),
            
            // Home and Living
            // Bookshelf
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.HomeAndLiving.Bookshelf,
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Brown
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.HomeAndLiving.Bookshelf,
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Wood
            ),
            
            // Dining Table Set
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.HomeAndLiving.DiningTable,
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.HomeAndLiving.ColorIds.Gray
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.HomeAndLiving.DiningTable,
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Ceramic
            ),
            
            // LED Floor Lamp
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.HomeAndLiving.LedFloorLamp,
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Color,
                SeedConstants.FeatureIds.HomeAndLiving.ColorIds.White
            ),
            SeedHelpers.CreateProductFeatureType(
                SeedConstants.ProductIds.HomeAndLiving.LedFloorLamp,
                SeedConstants.CategoryIds.HomeAndLiving,
                SeedConstants.FeatureTypeIds.Material,
                SeedConstants.FeatureIds.HomeAndLiving.MaterialIds.Metal
            )
        );
    }
}
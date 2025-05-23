using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Seeds;

public static class ProductSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            // Electronics
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.GalaxyS25,
                "Galaxy S25",
                "Samsung's latest smartphone",
                74999.00m,
                200,
                (int)SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.GalaxyS24,
                "Galaxy S24",
                "Samsung's flagship phone",
                54999.00m,
                200,
                (int)SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.LogitechMouse,
                "Logitech MX Master 3S",
                "Wireless performance mouse",
                3129.99m,
                110,
                (int)SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.LogitechKeyboard,
                "Logitech MX Keys",
                "Wireless illuminated keyboard",
                3119.99m,
                95,
                (int)SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.LogitechHeadset,
                "Logitech G Pro X",
                "Gaming headset with Blue VO!CE",
                5149.99m,
                70,
                (int)SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.LogitechGamepad,
                "Logitech F310",
                "Wired gamepad controller",
                529.99m,
                200,
                (int)SeedConstants.CategoryIds.Electronics
            ),
            
            // Clothing
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.PoloShirt,
                "Polo Shirt",
                "100% cotton polo shirt",
                299.99m,
                500,
                (int)SeedConstants.CategoryIds.Clothing
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.BlueDenimJean,
                "Blue Denim Jean",
                "Regular Fit Denim Jeans",
                599.99m,
                300,
                (int)SeedConstants.CategoryIds.Clothing
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.RunningShoes,
                "Running Shoes",
                "High-quality running shoes designed for daily training and comfort",
                899.99m,
                100,
                (int)SeedConstants.CategoryIds.Clothing
            ),
            
            // Home and Living
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Bookshelf,
                "Bookshelf",
                "5-tier wooden bookshelf",
                599.99m,
                30,
                (int)SeedConstants.CategoryIds.HomeAndLiving
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.DiningTable,
                "Dining Table Set",
                "Wooden dining table with 6 chairs",
                1899.99m,
                15,
                (int)SeedConstants.CategoryIds.HomeAndLiving
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.LedFloorLamp,
                "LED Floor Lamp",
                "Modern adjustable LED floor lamp",
                299.99m,
                50,
                (int)SeedConstants.CategoryIds.HomeAndLiving
            )
        );
    }
}
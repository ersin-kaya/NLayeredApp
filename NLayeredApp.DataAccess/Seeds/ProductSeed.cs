using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Seeds;

public static class ProductSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            // Electronics
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Electronics.GalaxyS25,
                "Galaxy S25",
                "Samsung's latest smartphone",
                74999.00m,
                200,
                SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Electronics.GalaxyS24,
                "Galaxy S24",
                "Samsung's flagship phone",
                54999.00m,
                200,
                SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Electronics.LogitechMouse,
                "Logitech MX Master 3S",
                "Wireless performance mouse",
                3129.99m,
                110,
                SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Electronics.LogitechKeyboard,
                "Logitech MX Keys",
                "Wireless illuminated keyboard",
                3119.99m,
                95,
                SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Electronics.LogitechHeadset,
                "Logitech G Pro X",
                "Gaming headset with Blue VO!CE",
                5149.99m,
                70,
                SeedConstants.CategoryIds.Electronics
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Electronics.LogitechGamepad,
                "Logitech F310",
                "Wired gamepad controller",
                529.99m,
                200,
                SeedConstants.CategoryIds.Electronics
            ),
            
            // Clothing
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Clothing.PoloShirt,
                "Polo Shirt",
                "100% cotton polo shirt",
                299.99m,
                500,
                SeedConstants.CategoryIds.Clothing
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Clothing.BlueDenimJean,
                "Blue Denim Jean",
                "Regular Fit Denim Jeans",
                599.99m,
                300,
                SeedConstants.CategoryIds.Clothing
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.Clothing.RunningShoes,
                "Running Shoes",
                "High-quality running shoes designed for daily training and comfort",
                899.99m,
                100,
                SeedConstants.CategoryIds.Clothing
            ),
            
            // Home and Living
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.HomeAndLiving.Bookshelf,
                "Bookshelf",
                "5-tier wooden bookshelf",
                599.99m,
                30,
                SeedConstants.CategoryIds.HomeAndLiving
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.HomeAndLiving.DiningTable,
                "Dining Table Set",
                "Wooden dining table with 6 chairs",
                1899.99m,
                15,
                SeedConstants.CategoryIds.HomeAndLiving
            ),
            SeedHelpers.CreateProduct(
                SeedConstants.ProductIds.HomeAndLiving.LedFloorLamp,
                "LED Floor Lamp",
                "Modern adjustable LED floor lamp",
                299.99m,
                50,
                SeedConstants.CategoryIds.HomeAndLiving
            )
        );
    }
}
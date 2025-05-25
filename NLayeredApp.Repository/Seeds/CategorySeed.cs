using Microsoft.EntityFrameworkCore;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Seeds;

public static class CategorySeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            SeedHelpers.CreateCategory(
                SeedConstants.CategoryIds.Electronics,
                "Electronics",
                "Electronic products category"
            ),
            SeedHelpers.CreateCategory(
                SeedConstants.CategoryIds.Clothing,
                "Clothing",
                "Clothing products category"
            ),
            SeedHelpers.CreateCategory(
                SeedConstants.CategoryIds.HomeAndLiving,
                "Home & Living",
                "Home and living products"
            )
        );
    }
}
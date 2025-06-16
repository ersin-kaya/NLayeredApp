using Microsoft.EntityFrameworkCore;
using NLayeredApp.DataAccess.Identity;

namespace NLayeredApp.DataAccess.Seeds.Identity;

public static class ApplicationUserSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationUser>().HasData(
            SeedHelpers.CreateUser(
                1,
                "admin",
                "admin@example.com",
                true,
                "System",
                "Administrator",
                "Admin@123"
            )
        );
    }
}
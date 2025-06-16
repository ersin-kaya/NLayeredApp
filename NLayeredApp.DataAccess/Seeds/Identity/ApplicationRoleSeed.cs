using Microsoft.EntityFrameworkCore;
using NLayeredApp.DataAccess.Identity;

namespace NLayeredApp.DataAccess.Seeds.Identity;

public static class ApplicationRoleSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationRole>().HasData(
            SeedHelpers.CreateRole(
                1,
                "Admin",
                "Administrator role"
            ),
            SeedHelpers.CreateRole(
                2,
                "User",
                "Standard user role"
            )
        );
    }
}
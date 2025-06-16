using Microsoft.EntityFrameworkCore;
using NLayeredApp.DataAccess.Identity;

namespace NLayeredApp.DataAccess.Seeds.Identity;

public static class ApplicationUserRoleSeed
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationUserRole>().HasData(
            SeedHelpers.CreateUserRole(
                1,
                1
            )
        );
    }
}
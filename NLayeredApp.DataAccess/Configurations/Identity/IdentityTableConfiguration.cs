using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace NLayeredApp.DataAccess.Configurations.Identity;

public static class IdentityTableConfiguration
{
    public static void ConfigureIdentityTables(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
        modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
        modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
        modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
    }
}
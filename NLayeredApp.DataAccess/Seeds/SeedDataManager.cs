using Microsoft.EntityFrameworkCore;
using NLayeredApp.DataAccess.Seeds.Identity;

namespace NLayeredApp.DataAccess.Seeds;

public static class SeedDataManager
{
    public static void ApplySeedData(ModelBuilder modelBuilder)
    {
        if (modelBuilder == null)
            throw new ArgumentNullException(nameof(modelBuilder));

        // Order 1: Main/Independent tables (no foreign keys)
        ApplicationRoleSeed.Apply(modelBuilder);
        ApplicationUserSeed.Apply(modelBuilder);
        
        CategorySeed.Apply(modelBuilder);
        FeatureTypeSeed.Apply(modelBuilder);
            
        // Order 2: Single dependency tables (1 foreign key)
        CategoryFeatureTypeSeed.Apply(modelBuilder);
        FeatureSeed.Apply(modelBuilder);
        ProductSeed.Apply(modelBuilder);
            
        // Order 3: Multiple dependency tables (2+ foreign keys)
        ApplicationUserRoleSeed.Apply(modelBuilder);
        
        ProductFeatureTypeSeed.Apply(modelBuilder);
    }
}
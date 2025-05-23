namespace NLayeredApp.Repository.Seeds;
using Microsoft.EntityFrameworkCore;

public static class SeedDataManager
{
    public static void ApplySeedData(ModelBuilder modelBuilder)
    {
        if (modelBuilder == null)
            throw new ArgumentNullException(nameof(modelBuilder));

        // Order 1: Main/Independent tables (no foreign keys)
        CategorySeed.Apply(modelBuilder);
        FeatureTypeSeed.Apply(modelBuilder);
            
        // Order 2: Single dependency tables (1 foreign key)
        CategoryFeatureTypeSeed.Apply(modelBuilder);
        FeatureSeed.Apply(modelBuilder);
        ProductSeed.Apply(modelBuilder);
            
        // Order 3: Multiple dependency tables (2+ foreign keys)
        ProductFeatureTypeSeed.Apply(modelBuilder);
    }
}
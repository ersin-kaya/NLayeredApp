using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Configurations;

public class CategoryFeatureTypeConfiguration : IEntityTypeConfiguration<CategoryFeatureType>
{
    public void Configure(EntityTypeBuilder<CategoryFeatureType> builder)
    {
        builder.HasKey(cft => new { cft.CategoryId, cft.FeatureTypeId });

        builder.Property(cft => cft.Label)
            .HasMaxLength(100);

        builder.Property(cft => cft.IsRequired)
            .HasDefaultValue(false);

        builder.HasOne(cft => cft.Category)
            .WithMany(c => c.CategoryFeatureTypes)
            .HasForeignKey(cft => cft.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(cft => cft.FeatureType)
            .WithMany(ft => ft.CategoryFeatureTypes)
            .HasForeignKey(cft => cft.FeatureTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
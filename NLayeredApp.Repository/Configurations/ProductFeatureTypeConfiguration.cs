using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Configurations;

public class ProductFeatureTypeConfiguration : IEntityTypeConfiguration<ProductFeatureType>
{
    public void Configure(EntityTypeBuilder<ProductFeatureType> builder)
    {
        builder.HasKey(pft => new { pft.ProductId, pft.FeatureTypeId });

        builder.HasOne(pft => pft.Product)
            .WithMany(p => p.ProductFeatureTypes)
            .HasForeignKey(pft => pft.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(pft => pft.CategoryFeatureType)
            .WithMany(cft => cft.ProductFeatureTypes)
            .HasForeignKey(pft => new { pft.CategoryId, pft.FeatureTypeId })
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(pft => pft.Feature)
            .WithMany()
            .HasForeignKey(pft => pft.FeatureId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasIndex(pft => pft.FeatureId);
    }
}
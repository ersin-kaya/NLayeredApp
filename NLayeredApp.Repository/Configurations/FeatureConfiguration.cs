using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Configurations;

public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.HasKey(f => f.Id);
        
        builder.Property(f => f.Value)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(f => f.CategoryFeatureType)
            .WithMany(cft => cft.Features)
            .HasForeignKey(f => new { f.CategoryId, f.FeatureTypeId })
            .OnDelete(DeleteBehavior.Cascade);
    }
}
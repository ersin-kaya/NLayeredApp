using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Configurations;

public class FeatureTypeConfiguration : IEntityTypeConfiguration<FeatureType>
{
    public void Configure(EntityTypeBuilder<FeatureType> builder)
    {
        builder.HasKey(ft => ft.Id);
        
        builder.Property(ft => ft.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(ft => ft.Name)
            .IsUnique();
    }
}
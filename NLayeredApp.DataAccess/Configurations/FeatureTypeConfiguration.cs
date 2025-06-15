using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Configurations;

public class FeatureTypeConfiguration : IEntityTypeConfiguration<FeatureType>
{
    public void Configure(EntityTypeBuilder<FeatureType> builder)
    {
        builder.HasKey(ft => ft.Id);
        
        // Properties
        builder.Property(ft => ft.Name)
            .IsRequired()
            .HasMaxLength(ApplicationConstants.FeatureType.NameMaxLength);

        // Indexes
        builder.HasIndex(ft => ft.Name)
            .IsUnique();
    }
}
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
        
        builder.Property(ft => ft.Name)
            .IsRequired()
            .HasMaxLength(ApplicationConstants.FeatureTypeNameMaxLength);

        builder.HasIndex(ft => ft.Name)
            .IsUnique();
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.Description)
            .HasMaxLength(1000);

        builder.Property(c => c.IsActive)
            .HasDefaultValue(true);
        
        builder.HasIndex(c => c.Name)
            .IsUnique();
        
        builder.Property(e => e.CreatedBy)
            .HasMaxLength(100);

        builder.Property(e => e.LastModifiedBy)
            .HasMaxLength(100);
    }
}
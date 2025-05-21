using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.Repository.Configurations;

public class CategoryConfiguration : AuditableEntityConfiguration<Category>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        base.Configure(builder);

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
    }
}
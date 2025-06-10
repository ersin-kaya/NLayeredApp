using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(ApplicationConstants.CategoryNameMaxLength);

        builder.Property(c => c.Description)
            .HasMaxLength(ApplicationConstants.CategoryDescriptionMaxLength);

        builder.Property(c => c.IsActive)
            .HasDefaultValue(ApplicationConstants.CategoryIsActive);
        
        builder.HasIndex(c => c.Name)
            .IsUnique();
        
        builder.Property(e => e.CreatedBy)
            .HasMaxLength(ApplicationConstants.AuditFields.CreatedByMaxLength);

        builder.Property(e => e.LastModifiedBy)
            .HasMaxLength(ApplicationConstants.AuditFields.LastModifiedByMaxLength);
    }
}
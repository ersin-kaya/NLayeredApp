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
        
        #region Properties
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(ApplicationConstants.Category.NameMaxLength);

        builder.Property(c => c.Description)
            .HasMaxLength(ApplicationConstants.Category.DescriptionMaxLength);

        builder.Property(c => c.IsActive)
            .HasDefaultValue(ApplicationConstants.Category.IsActiveDefault);
        
        builder.Property(e => e.CreatedBy)
            .HasMaxLength(ApplicationConstants.AuditFields.CreatedByMaxLength);

        builder.Property(e => e.LastModifiedBy)
            .HasMaxLength(ApplicationConstants.AuditFields.LastModifiedByMaxLength);
        #endregion
        
        // Indexes
        builder.HasIndex(c => c.Name).IsUnique();
    }
}
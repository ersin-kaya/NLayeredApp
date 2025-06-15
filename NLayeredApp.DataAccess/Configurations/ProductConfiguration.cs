using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayeredApp.Core.Constants;
using NLayeredApp.Core.Entities;

namespace NLayeredApp.DataAccess.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        #region Properties
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(ApplicationConstants.Product.NameMaxLength);

        builder.Property(p => p.Description)
            .HasMaxLength(ApplicationConstants.Product.DescriptionMaxLength);

        builder.Property(p => p.Price)
            .HasPrecision(ApplicationConstants.Product.PricePrecision, ApplicationConstants.Product.PriceScale);

        builder.Property(p => p.IsActive)
            .HasDefaultValue(ApplicationConstants.Product.IsActiveDefault);

        builder.Property(p => p.DeletedBy)
            .HasMaxLength(ApplicationConstants.AuditFields.DeletedByMaxLength);

        builder.Property(p => p.IsDeleted)
            .HasDefaultValue(ApplicationConstants.Product.IsDeletedDefault);
        
        builder.Property(e => e.CreatedBy)
            .HasMaxLength(ApplicationConstants.AuditFields.CreatedByMaxLength);

        builder.Property(e => e.LastModifiedBy)
            .HasMaxLength(ApplicationConstants.AuditFields.LastModifiedByMaxLength);
        #endregion

        // Relationships
        builder.HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
        
        // Indexes
        builder.HasIndex(p => p.Name);
        builder.HasIndex(p => p.CategoryId);
        builder.HasIndex(p => new { p.CategoryId, p.Price });
        
        // Global Query Filter
        builder.HasQueryFilter(p => !p.IsDeleted);
    }
}
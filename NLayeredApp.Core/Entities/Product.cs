﻿using NLayeredApp.Core.Common;
using NLayeredApp.Core.Constants;

namespace NLayeredApp.Core.Entities
{
    public class Product : AuditableEntity, IActivatable, ISoftDeletable
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public bool IsActive { get; set; } = ApplicationConstants.Product.IsActiveDefault;

        public DateTimeOffset? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public bool IsDeleted { get; set; } = ApplicationConstants.Product.IsDeletedDefault;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<ProductFeatureType> ProductFeatureTypes { get; set; } = new List<ProductFeatureType>();
    }
}

using NLayeredApp.Core.Common;

namespace NLayeredApp.Core.Entities
{
    public class Category : AuditableEntity, IActivatable
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<CategoryFeatureType> CategoryFeatureTypes { get; set; } = new List<CategoryFeatureType>();
    }
}

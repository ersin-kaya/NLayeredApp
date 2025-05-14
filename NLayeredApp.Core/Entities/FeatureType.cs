using NLayeredApp.Core.Common;

namespace NLayeredApp.Core.Entities
{
    public class FeatureType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<CategoryFeatureType> CategoryFeatureTypes { get; set; } = new List<CategoryFeatureType>();
    }
}

using NLayeredApp.Core.Common;

namespace NLayeredApp.Core.Entities
{
    public class Feature : BaseEntity
    {
        public string Value { get; set; } = string.Empty;

        public int CategoryId { get; set; }
        public int FeatureTypeId { get; set; }

        public CategoryFeatureType CategoryFeatureType { get; set; } = null!;
    }
}

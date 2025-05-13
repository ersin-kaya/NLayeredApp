namespace NLayeredApp.Core.Entities
{
    public class CategoryFeatureType
    {
        // composite pk
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public int FeatureTypeId { get; set; }
        public FeatureType FeatureType { get; set; } = null!;

        public bool IsRequired { get; set; } = false;
        public string? Label { get; set; }

        public ICollection<Feature> Features { get; set; } = new List<Feature>();
        public ICollection<ProductFeatureType> ProductFeatureTypes { get; set; } = new List<ProductFeatureType>(); // bu sınıftaki CategoryId-FeatureTypeId kombinasyonu birden fazla Product tarafından kullanılabilir
    }
}

namespace NLayeredApp.Core.Entities
{
    public class ProductFeatureType
    {
        // composite pk
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int CategoryId { get; set; }
        public int FeatureTypeId { get; set; }

        public CategoryFeatureType CategoryFeatureType { get; set; } = null!; // bu ilişki Product'ın ait olduğu Category içinde tanımlı olan bir FeatureType'ı temsil ediyor
                                                                              // yani Product kendi Category'sine ait geçerli bir FeatureType ile eşleşebilir

        public int FeatureId { get; set; }
        public Feature Feature { get; set; } = null!;
    }
}

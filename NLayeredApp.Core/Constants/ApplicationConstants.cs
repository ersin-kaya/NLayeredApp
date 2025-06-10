namespace NLayeredApp.Core.Constants;

public static class ApplicationConstants
{
    public static class Pagination
    {
        public const int DefaultPageNumber = 1;
        public const int DefaultPageSize = 10;
        public const int MaxPageSize = 100;
        public const int MinPageSize = 1;
        public const bool DefaultIsDescending = false;
    }
    
    /// <summary>
    /// Common audit field constants
    /// </summary>
    public static class AuditFields
    {
        private const int UserNameMaxLength = 100;
        
        public const int CreatedByMaxLength = UserNameMaxLength;
        public const int LastModifiedByMaxLength = UserNameMaxLength;
        public const int DeletedByMaxLength = UserNameMaxLength;
    }
    
    // Category entity constants
    public const int CategoryNameMaxLength = 50;
    public const int CategoryDescriptionMaxLength = 1000;
    public const bool CategoryIsActive = true;
    
    // Product entity constants
    public const int ProductNameMaxLength = 200;
    public const int ProductDescriptionMaxLength = 2000;
    public const int ProductPricePrecision = 18;
    public const int ProductPriceScale = 2;
    public const bool ProductIsActive = true;
    public const bool ProductIsDeleted = false;
    
    // CategoryFeatureType entity constants
    public const int CategoryFeatureTypeLabelMaxLength = 100;
    public const bool CategoryFeatureTypeIsRequired = false;

    // Feature entity constants
    public const int FeatureValueMaxLength = 100;

    // FeatureType entity constants
    public const int FeatureTypeNameMaxLength = 100;
}